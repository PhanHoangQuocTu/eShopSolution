using eShopSolution.Data.Dtos.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Data.EF
{
    public static class DatabaseFacadeExt
    {
        public static async Task NonQuery(this DatabaseFacade database, string sql, List<SqlParameter> parameters)
        {
            using (var command = database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                database.OpenConnection();

                if (parameters != null)
                {
                    foreach (var kvp in parameters)
                    {
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = kvp.Key;
                        parameter.Value = kvp.Value;
                        command.Parameters.Add(parameter);
                    }
                }

                await command.ExecuteScalarAsync();
            }
        }

        public static async Task<List<T>> SqlQueryAsync<T>(this DatabaseFacade database, string sql, List<SqlParameter> parameters) where T : new()
        {
            using (var command = database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                database.OpenConnection();

                if (parameters != null)
                {
                    foreach (var kvp in parameters)
                    {
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = kvp.Key;
                        parameter.Value = kvp.Value;
                        command.Parameters.Add(parameter);
                    }
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        return DataTableToList<T>(dt);
                    }
                    else
                    {
                        return new List<T>();
                    }
                }
            }
        }

        private static List<T> DataTableToList<T>(DataTable table) where T : new()
        {
            var list = new List<T>();

            var typeProperties = typeof(T)
                .GetProperties()
                .Select(propertyInfo => new
                {
                    PropertyInfo = propertyInfo,
                    Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
                })
                .ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {
                T obj = new T();

                foreach (var typeProperty in typeProperties)
                {
                    if (row.Table.Columns.Contains(typeProperty.PropertyInfo.Name))
                    {
                        object value = row[typeProperty.PropertyInfo.Name];
                        object? safeValue = value == null || DBNull.Value.Equals(value)
                            ? null
                            : Convert.ChangeType(value, typeProperty.Type);

                        typeProperty.PropertyInfo.SetValue(obj, safeValue, null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}


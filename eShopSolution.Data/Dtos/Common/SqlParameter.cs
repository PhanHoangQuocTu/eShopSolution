using System;
namespace eShopSolution.Data.Dtos.Common
{
    public class SqlParameter
    {
        public SqlParameter()
        {
            Key = string.Empty;
            Value = string.Empty;
        }

        public SqlParameter(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}    

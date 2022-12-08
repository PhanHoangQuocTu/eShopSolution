using eShopSolution.Data.Dtos.Common;
using eShopSolution.Data.Dtos.Product;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Data.Repository
{
    public interface IProductRepository : IRepository<ProductsM>
    {
        public Task<List<ProductVm>> GetProductsBy(int pageIndex, int pageSize, string keyword);
        Task<int> CountProductsBy(int pageIndex, int pageSize, string keyword);
    }

    public class ProductRepository : Repository<ProductsM>, IProductRepository
    {
        #region SQL
        private readonly string QueryGetProducts = @"SELECT id as Id, code as Code, name as Name, import_price as ImportPrice, 
        price as Price, quantity_in_stock as QuantityInStock 
        FROM [dbo].[ProductsM] ";

        private readonly string QueryProductsCount = "SELECT count(1) as Total FROM [dbo].[ProductsM] ";

        #endregion
        public ProductRepository(EShopDbContext context) : base(context)
        {
        }

        #region PUBLIC METHOD
        public async Task<List<ProductVm>> GetProductsBy(int pageIndex, int pageSize, string keyword)
        {
            var sql = QueryGetProducts + BuildCondition(pageIndex, pageSize, keyword) + $" order by created_at desc OFFSET {pageIndex}  ROWS FETCH NEXT {pageSize} ROWS ONLY;";

            return await _context.Database.SqlQueryAsync<ProductVm>(sql, new List<SqlParameter>());
        }

        public async Task<int> CountProductsBy(int pageIndex, int pageSize, string keyword)
        {
            string sql = QueryProductsCount + BuildCondition(pageIndex, pageSize, keyword);

            return GetValue(await _context.Database.SqlQueryAsync<TotalObj>(sql, new List<SqlParameter>()));
        }
        #endregion

        
        #region PRIVATE METHOD
        private static string BuildCondition(int pageIndex, int pageSize, string keyword)
        {
            var condition = " WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(keyword))
                condition += $" AND code like '%{keyword}%' or name like '%{keyword}%'";

            return condition;
        }

        private static int GetValue(List<TotalObj> result)
        {
            if (result == null || result.SingleOrDefault() == null) return 0;

            var temVal = result.SingleOrDefault();

            return temVal == null ? 0 : temVal.Total;
        }
        #endregion
    }
}

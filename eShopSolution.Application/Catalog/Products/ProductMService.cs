using dbo_capital_service.Infrastructure.DBContext;
using eShopSolution.Data.Dtos.Common;
using eShopSolution.Data.Dtos.Product;
using eShopSolution.Data.Entities;
using System;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IProductMService
    {
        Task<ApiResult<PagedResult<ProductVm>>> GetAllPaging(GetManageProductPagingRequest request);
        Task<ApiResult<bool>> Create(ProductCreateRequest request);
        Task<ApiResult<bool>> Update(ProductUpdateRequest request);
        Task<ApiResult<bool>> Delete(string productId);
    }

    public class ProductMService : IProductMService
    {
        private readonly static int _maxPageSize = 100;
        private readonly static int _defaultPageSize = 15;
        private readonly IUnitOfWork _uok;

        public ProductMService(IUnitOfWork uok) => _uok = uok;

        public async Task<ApiResult<PagedResult<ProductVm>>> GetAllPaging(GetManageProductPagingRequest request)
        {
            HandlePaging(request);

            var pagedResult = new PagedResult<ProductVm>()
            {
                TotalRecords = await _uok.Product.CountProductsBy(request.PageIndex, request.PageSize, request.Keyword),
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = await _uok.Product.GetProductsBy(request.PageIndex, request.PageSize, request.Keyword)
            };

            return new ApiSuccessResult<PagedResult<ProductVm>>(pagedResult);
        }

        private static void HandlePaging(GetManageProductPagingRequest dto)
        {
            if (dto.PageIndex <= 1) dto.PageIndex = 1;
            if (dto.PageSize <= 15) dto.PageSize = _defaultPageSize;
            if (dto.PageSize >= 100) dto.PageSize = _maxPageSize;

            dto.PageIndex = (dto.PageIndex - 1) * dto.PageSize;
        }

        public async Task<ApiResult<bool>> Create(ProductCreateRequest request)
        {
            try
            {
                if (await _uok.Product.GetFirstOrDefaultAsync(x => x.Code == request.Code) != null)
                    return new ApiErrorResult<bool>("Tài khoản đã tồn tại");

                _uok.Product.Add(new ProductsM()
                {
                    Code = request.Code,
                    Name = request.Name,
                    ImportPrice = request.ImportPrice,
                    Price = request.Price,
                    QuantityInStock = request.QuantityInStock,
                    CreatedAt = DateTime.Now
                });

                await _uok.CompleteAsync();

                return new ApiSuccessResult<bool>();
            }
            catch
            {
                return new ApiErrorResult<bool>("Đăng ký không thành công");
            }
        }

        public async Task<ApiResult<bool>> Update(ProductUpdateRequest request)
        {
            try
            {
                var product = await _uok.Product.GetByIdAsync(request.Id);
                if (product == null)
                    return new ApiErrorResult<bool>("Sản phẩm không tồn tại");

                product.Name = request.Name;
                product.ImportPrice = request.ImportPrice;
                product.Price = request.Price;
                product.QuantityInStock = request.QuantityInStock;

                _uok.Product.Update(product);

                await _uok.CompleteAsync();

                return new ApiSuccessResult<bool>();
            }
            catch
            {
                return new ApiErrorResult<bool>("Cập nhật không thành công");
            }
        }

        public async Task<ApiResult<bool>> Delete(string productId)
        {
            try
            {
                var product = await _uok.Product.GetByIdAsync(productId);
                if (product == null)
                    return new ApiErrorResult<bool>("Sản phẩm không tồn tại");

                _uok.Product.Remove(product);

                await _uok.CompleteAsync();

                return new ApiSuccessResult<bool>();
            }
            catch
            {
                return new ApiErrorResult<bool>("Xóa không thành công");
            }
        }
    }
}

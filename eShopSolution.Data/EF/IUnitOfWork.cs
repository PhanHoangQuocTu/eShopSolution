
using eShopSolution.Data.EF;
using eShopSolution.Data.Repository;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace dbo_capital_service.Infrastructure.DBContext
{
    public interface IUnitOfWork : IDisposable  
    {
        Task<int> CompleteAsync();
        IProductRepository Product { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly EShopDbContext _context;
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);

        public UnitOfWork(EShopDbContext context)
        {
            _context = context;
            Product = new ProductRepository(_context);
        }

        public IProductRepository Product { get; private set; }
		public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();

            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }
        }
    }
}



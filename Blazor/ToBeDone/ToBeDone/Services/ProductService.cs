namespace ToBeDone.Services
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using ToBeDone.Data;
    using ToBeDone.Models;
    public class ProductService
    {
        private readonly AddDbContext _context;
        public ProductService(AddDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

    }

}

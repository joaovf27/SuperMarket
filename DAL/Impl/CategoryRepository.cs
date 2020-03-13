using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task Insert(CategoryDTO category)
        {
            using (MarketContext context = new MarketContext())
            {
                 context.Categories.Add(category);
                await context.SaveChangesAsync();
            }
        }
    }
}

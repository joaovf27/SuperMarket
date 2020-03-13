using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl
{
    public class BrandRepository : IBrandRepository
    {
        public async Task Insert(BrandDTO brand)
        {
            using (MarketContext context = new MarketContext())
            {
                 context.Brands.Add(brand);
                await context.SaveChangesAsync();
            }
        }
    }
}

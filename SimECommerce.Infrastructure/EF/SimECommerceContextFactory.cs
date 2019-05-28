using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimECommerce.DAL.EF
{
    public class SimECommerceContextFactory : IDesignTimeDbContextFactory<SimECommerceContext>
    {
        public SimECommerceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SimECommerceContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=EcommerceSimplifie;Trusted_Connection=True;");
            return new SimECommerceContext(optionsBuilder.Options);
        }
    }
}

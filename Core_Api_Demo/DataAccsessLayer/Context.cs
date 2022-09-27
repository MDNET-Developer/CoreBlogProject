
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Api_Demo.DataAccsessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LV07HAI;database=Db_CoreApi;integrated security=true");
        }

        public DbSet<Isciler> Iscilers { get; set; }
    }
}

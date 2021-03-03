using DataAccess.ModelRepresentation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DBContext
{
    public class DailyTaskDBContext : DbContext
    {

        public DbSet<DailyTaskRepresentation> DailyTaskTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=DESKTOP-UDC63P9;Initial Catalog=DailyTaskDB;Integrated Security=True;");
        }


    }
}

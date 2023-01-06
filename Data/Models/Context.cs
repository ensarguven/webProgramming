using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Context : DbContext
    {
        //veritabanı ile etkileşim 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BDA79D2; database=DbCoreFood; integrated security=true");
        }

        //modelin içinde tanımladığımız entity sınıflarını buraya tanımlıyoruz
        //burdaki entity sınıfları birer tablo olarak veritabanına yansıcak
        public DbSet<Food> Foods { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet<Admin> Admins{ get; set; }



    //bu değişiklikleri migration üzerinden veritabanına yansıtabilmek için nuget pakatlerini indiricez.
}
}

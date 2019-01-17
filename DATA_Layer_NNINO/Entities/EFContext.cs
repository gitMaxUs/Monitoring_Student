using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DATA_Layer_NNINO.Entities
{
    public class EFContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        //static EFContext()
        //{
        //    Database.SetInitializer<EFContext>(new StoreDbInitializer());
        //}


        //public EFContext(string connectionString)
        //    : base(connectionString)
        public EFContext()
           : base("NNINO_Web_API")
        {
        }


    }
    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<MobileContext>
    //{
    //    protected override void Seed(MobileContext db)
    //    {
    //        db.Phones.Add(new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
    //        db.Phones.Add(new Phone { Name = "iPhone 6", Company = "Apple", Price = 320 });
    //        db.Phones.Add(new Phone { Name = "LG G4", Company = "lG", Price = 260 });
    //        db.Phones.Add(new Phone { Name = "Samsung Galaxy S 6", Company = "Samsung", Price = 300 });
    //        db.SaveChanges();
    //    }
    //}
}

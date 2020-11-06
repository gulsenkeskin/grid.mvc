using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc.Grid.Models.Manager
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }

        public DbSet<Adres> Adresler { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new Olusturucu());
        }
        
    }


    public class Olusturucu:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            List<Ulke> ulkeList = new List<Ulke>();
            for (int i = 0; i < 10; i++)
            {
                Ulke ulke = new Ulke();
                ulke.Ad = FakeData.PlaceData.GetCountry();
                ulkeList.Add(ulke);
                context.Ulkeler.Add(ulke);
            }
            context.SaveChanges();

            for (int i = 0; i < 100; i++)
            {
                Personel per = new Personel();
                per.Ad = FakeData.NameData.GetFirstName();
                per.Soyad = FakeData.NameData.GetSurname();
                per.Yas = FakeData.NumberData.GetNumber(10, 90);

                Random r = new Random();
                int deger = r.Next(0, 10);
                per.Ulke = ulkeList[deger];
                context.Personeller.Add(per);
            }
            context.SaveChanges();
        }
    }
}
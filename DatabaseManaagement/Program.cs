using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JessicaHenry_S00214115_Practical; 

namespace DatabaseManaagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Database Object 
            CarData db = new CarData();

            using (db)
            {
                //Create Cars
                Car c1 = new Car()
                {
                    Name = "ix35",
                    Brand = "Hyundai",
                    DateRelease = RandomDate().Year,
                    Description = "The Hyundai ix35 is a family SUV in the mould of the Nissan Qashqai, Skoda Yeti and its sister car, the Kia Sportage. It has now been replaced by the Hyundai Tucson, but as it was on sale for six years, there are plenty around on the used market.",
                    Price = 14000, 
                    Km = 40000, 
                    Model = "SUV", 
                    Brand_Icon = "/Images/Hyundai.png",
                    Car_Image = "/Images/ix35.jpg"
                };

                Car c2 = new Car()
                {
                    Name = "Q3",
                    Brand = "Audi",
                    DateRelease = RandomDate().Year,
                    Description = "The interior of the new Q3 is a combination of luxury, sportiness and intuitive design",
                    Price = 57000,
                    Km = 4000,
                    Model = "SUV",
                    Brand_Icon = "/Images/audi.png",
                    Car_Image = "/Images/q3.jpg"
                };
                Car c3 = new Car()
                {
                    Name = "x6",
                    Brand = "BMW",
                    DateRelease = RandomDate().Year,
                    Description = "The interior of the new Q3 is a combination of luxury, sportiness and intuitive design",
                    Price = 45000,
                    Km = 56000,
                    Model = "SUV",
                    Brand_Icon = "/Images/bmw.png",
                    Car_Image = "/Images/x6.jpg"
                };
                Car c4 = new Car()
                {
                    Name = "Tucson",
                    Brand = "Hyundai",
                    DateRelease = RandomDate().Year,
                    Description = "The Hyundai Tucson is a family SUV.",
                    Price = 14000,
                    Km = 40000,
                    Model = "SUV",
                    Brand_Icon = "/Images/Hyundai.png",
                    Car_Image = "/Images/tucson.jpg"
                };

                Console.WriteLine("Cars Created");
                //Add car to db
                db.Cars.Add(c1);
                db.Cars.Add(c2);
                db.Cars.Add(c3);
                db.Cars.Add(c4);
                Console.WriteLine("Cars Add to Db");

                db.SaveChanges(); 
                Console.WriteLine("Car Saved to Database");
                //Save db

                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }

            
        }
        private static DateTime RandomDate()
        {
            Random rnd = new Random();
            DateTime today = DateTime.Now;
            DateTime DateYears = today.AddYears(rnd.Next(1, 10));
            return DateYears;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessicaHenry_S00214115_Practical
{
    public class Car
    {
        //propreties 
        [Key]
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public decimal Price { get; set; }
        public int DateRelease { get; set; }
        public string Car_Image { get; set; }
        public string Brand_Icon { get; set; }

        //constructors

        //methods
        public decimal DecreasePrice(int descont)
        {
            return Price - (Price * descont/100) ;
        }

        public override string ToString()
        {
            return $"{Name}"; 
        }
        public string CarDetails()
        {
            return $"{Name}\n{Description}\n{Brand}\n{Model}\n{Km} \n{Price:C}\n{DateRelease}";
        }
    }
    //Database 
    public class CarData : DbContext
    {
        public CarData() : base("MyCarDatav1") { }
        public DbSet<Car> Cars { get; set; }

    }
}

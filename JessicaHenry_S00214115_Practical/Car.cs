using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessicaHenry_S00214115_Practical
{
    public class Car
    {
        //propreties 
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public decimal Price { get; set; }
        public DateTime DateRelease { get; set; }
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

    }
}

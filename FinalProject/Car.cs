using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Car 
    {
        static int counter = 0;

        public Car()
        {
            this.CarId = ++counter;
        }
        public int ModelId1 { get; set; }
        public int CarId { get; set; }
        public DateTime Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public string FuelType { get; set; }

        public override string ToString()
        {
            return $"Model ID: {ModelId1}\n" + $"Car ID: {CarId}\n" + $"Year: {Year}\n" + $"Price: {Price}\n" + $"Color: {Color}\n" +
                $"Engine: {Engine}\n" +
                $"FuelType: {FuelType}";
        }

    }
}

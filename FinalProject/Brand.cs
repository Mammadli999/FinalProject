using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Brand
    {

        static int counter = 0;

        public Brand()
        {
            this.BrandId=++counter;
        }
        public int BrandId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Brand Id: {BrandId}\n" +
                $"Brand Name: {Name}";
        }
    }
}

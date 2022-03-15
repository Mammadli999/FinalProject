using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Model 
    {
        static int counter = 0;
        public Model()
        {
            this.ModelId = ++counter;
        }
        public int ModelId { get; set; }

        public string ModelName { get; set; }

        public int BrandId1 { get; set; }

        public override string ToString()
        {
            return $"Model ID: {ModelId}\n" +
                $"Model Name: {ModelName}\n" +
                $"Brand ID: {BrandId1}";
        }
    }
}

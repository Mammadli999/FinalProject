using FinalProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Managers
{
    internal class BrandManager
    {
        Brand[] data = new Brand[0];

        public void Add(Brand entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }

        public void BrandRemove(Brand entity)
        {
            int index = Array.IndexOf(data, entity);

            if (index == -1)
            {
                return;
            }

            for (int i = index; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            if (data.Length > 0)
            {
                Array.Resize(ref data, data.Length - 1);
            }

        }


        public void BrandSingle(int value)
        {
            string singleBrand = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].BrandId == value)
                {
                    singleBrand = $"Brand ID: {data[i].BrandId}\n" +
                        $"Brand's Name: {data[i].Name}";
                }
            }
            Console.WriteLine(singleBrand);
        }

        
        public void BrandEdit(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].BrandId == value)
                {
                    Console.WriteLine("Choose your Group : ");
                    string NewBrand = ScannerManager.ReadString("Enter the New Brand: ");
                    data[i].Name = data[i].Name.Replace(data[i].Name, NewBrand);
                }
            }
        }

        public Brand[] GetAll()
        {
            return data;
        }
    }
}

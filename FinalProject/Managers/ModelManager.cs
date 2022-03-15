using FinalProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Managers
{
    internal class ModelManager
    {
        Model[] data = new Model[0];

        public void Add(Model entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }

        public void ModelRemove(Model entity)
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

        public void ModelSingle(int value)
        {
            string ModelSingle = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    ModelSingle = $"Model ID: {data[i].ModelId}\n" +
                        $"Model's Name: {data[i].ModelName}\n" +
                        $"Brand ID: {data[i].BrandId1}";
                }
            }
            Console.WriteLine(ModelSingle);
        }


        public void ModelEditBrandId(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    Console.WriteLine("Change the Model Brand: ");
                    int NewBrandId = ScannerManager.ReadInteger("Enter the ID of  New Brand: ");
                    data[i].BrandId1 = NewBrandId;
                    break;
                }
            }
        }

        public void ModelEditName(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ModelId == value)
                {
                    Console.WriteLine("Change the Model Name: ");
                    string NewBrand = ScannerManager.ReadString("Enter the New Model Name: ");
                    data[i].ModelName = data[i].ModelName.Replace(data[i].ModelName, NewBrand);
                    break;
                }
            }
        }

        public Model[] GetAll()
        {
            return data;
        }
            
    }
}

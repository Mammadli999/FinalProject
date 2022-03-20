using FinalProject.Infrastructure;
using FinalProject.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Managers
{
    internal class CarManager
    {
        Car[] data = new Car[0];

        public void Add(Car entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }

        public void CarRemove(Car entity)
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

        public void CarSingle(int value)
        {
            string carSingle = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    carSingle = $"Model ID: {data[i].ModelId1}\n" +
                        $"Car ID: {data[i].CarId}\n" +
                        $"Year: {data[i].Year}\n" +
                        $"Price: {data[i].Price}\n" +
                        $"Color: {data[i].Color}\n" +
                        $"Engine: {data[i].Engine}";
                }
            }
            Console.WriteLine(carSingle);
        }

        public void CarEditModelId(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the Model ID: ");
                    int NewModelId = ScannerManager.ReadInteger("Enter the New ID: ");
                    data[i].ModelId1 = NewModelId;
                    break;
                }
            }
        }

        public void CarEditYear(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the Year: ");
                    DateTime NewYear = ScannerManager.ReadDate("Enter the New Year: ");
                    data[i].Year = NewYear;
                    break;
                }
            }
        }

        public void CarEditPrice(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the Price: ");
                    double NewPrice = ScannerManager.ReadDouble("Enter the New Price: ");
                    data[i].Price = NewPrice;
                    break;
                }
            }
        }

        public void CarEditColor(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the Color: ");
                    string NewColor = ScannerManager.ReadString("Enter the New Color: ");
                    data[i].Color = data[i].Color.Replace(data[i].Color, NewColor);
                    break;
                }
            }
        }

        public void CarEditEngine(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the Engine: ");
                    double NewEngine = ScannerManager.ReadDouble("Enter the New Engine: ");
                    data[i].Engine = NewEngine;
                    break;
                }
            }
        }

        public void CarEditFuelType(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CarId == value)
                {
                    Console.WriteLine("Change the FuelType: ");
                    FuelType menuNum4 = ScannerManager.FuelType("Select the type a fuel: ");

                    switch (menuNum4)
                    {
                        case FuelType.Gasoline:
                            data[i].FuelType = nameof(FuelType.Gasoline);
                            break;
                        case FuelType.Diesel:
                            data[i].FuelType = nameof(FuelType.Diesel);
                            break;
                        case FuelType.Hybrid:
                            data[i].FuelType = nameof(FuelType.Hybrid);
                            break;
                        case FuelType.Electro:
                            data[i].FuelType = nameof(FuelType.Electro);
                            break;
                        case FuelType.Gas:
                            data[i].FuelType = nameof(FuelType.Gas);
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        public Car[] GetAll()
        {
            return data;
        }
    }
}

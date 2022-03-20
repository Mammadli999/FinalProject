using FinalProject.Infrastructure;
using FinalProject.Manager;
using FinalProject.Managers;
using System;
using System.Linq;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CarSystem v1.1";

            var brandMsr = new BrandManager();
            var modelMsr = new ModelManager();
            var carMsr = new CarManager();

            ReadMenu:
            PrintMenu();

            Menu menuNum = ScannerManager.ReadMenu("Choose an Operation in Menu: ");

            switch (menuNum)
            {
                case Menu.BrandAdd:
                    Console.Clear();
                    Brand b = new Brand();
                    b.Name = ScannerManager.ReadString("Enter the Brand's Name: ");
                    brandMsr.Add(b);

                    goto case Menu.BrandAll;
                    
                case Menu.BrandEdit:
                    Console.Clear();
                    ShowAllBrand(brandMsr);
                    
                    int value = ScannerManager.ReadInteger("Enter the ID of Brand: ");
                    brandMsr.BrandEdit(value);

                    goto case Menu.BrandAll;

                case Menu.BrandRemove:
                    Console.Clear();
                    ShowAllBrand(brandMsr);
                    int id = ScannerManager.ReadInteger("Silmek Istediyiniz Qrupun ID-ni Daxil Edin: ");

                    Brand b1 = brandMsr.GetAll().FirstOrDefault(item => item.BrandId == id);
                    brandMsr.BrandRemove(b1);
                    goto case Menu.BrandAll;

                case Menu.BrandSingle:
                    Console.Clear();
                    ShowAllBrand(brandMsr);
                    int idvalue = ScannerManager.ReadInteger("Enter the choosen Brand: ");
                    brandMsr.BrandSingle(idvalue);
                    goto ReadMenu;

                case Menu.BrandAll:
                    Console.Clear();
                    ShowAllBrand(brandMsr);

                    goto ReadMenu ;
                case Menu.ModelAdd:
                    Console.Clear();
                    Model m  = new Model();
                    m.ModelName = ScannerManager.ReadString("Enter the Model's Name: ");

                    ShowAllBrand(brandMsr);
                    m.BrandId1 = ScannerManager.ReadInteger("Enter the ID of Model: ");

                    modelMsr.Add(m);

                    goto case Menu.ModelAll;
                case Menu.ModelEdit:
                    Console.Clear();
                    ShowAllModel(modelMsr);
                    Console.WriteLine("Change for Model's Name ==> 1 || Change for Brand's ID ==> 2");
                    bool success = int.TryParse(Console.ReadLine(), out int menuNumber);
                    if (success && menuNumber == 1)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        modelMsr.ModelEditName(value1);
                    }
                    else if (success && menuNumber == 2)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        modelMsr.ModelEditBrandId(value1);
                    }

                    goto case Menu.ModelAll;

                case Menu.ModelRemove:
                    Console.Clear();
                    ShowAllModel(modelMsr);
                    int id1 = ScannerManager.ReadInteger("Silmek Istediyiniz Qrupun ID-ni Daxil Edin: ");

                    Model m1 = modelMsr.GetAll().FirstOrDefault(item => item.ModelId == id1);
                    modelMsr.ModelRemove(m1);
                    goto case Menu.ModelAll;

                case Menu.ModelSingle:
                    Console.Clear();
                    ShowAllModel(modelMsr);
                    int idvalue1 = ScannerManager.ReadInteger("Enter the choosen Model: ");
                    modelMsr.ModelSingle(idvalue1);
                    goto ReadMenu;

                case Menu.ModelAll:
                    Console.Clear();
                    ShowAllModel(modelMsr);

                    goto ReadMenu;
                case Menu.CarAdd:
                    Console.Clear();
                    Car c = new Car();
                    c.Year = ScannerManager.ReadDate("Enter the Car's Year: ");
                    c.Price = ScannerManager.ReadDouble("Enter the Car's Price: ");
                    c.Color = ScannerManager.ReadString("Enter the Car's Color: ");
                    c.Engine = ScannerManager.ReadDouble("Enther the Car's Engine: ");

                    PrintFuelMenu();
                    FuelType menuNum4 = ScannerManager.FuelType("Select the type a fuel: ");

                    switch (menuNum4)
                    {
                        case FuelType.Gasoline:
                            c.FuelType = nameof(FuelType.Gasoline);
                            break;
                        case FuelType.Diesel:
                            c.FuelType = nameof(FuelType.Diesel);
                            break;
                        case FuelType.Hybrid:
                            c.FuelType = nameof(FuelType.Hybrid);
                            break;
                        case FuelType.Electro:
                            c.FuelType = nameof(FuelType.Electro);
                            break;
                        case FuelType.Gas:
                            c.FuelType = nameof(FuelType.Gas);
                            break;
                        default:
                            break;
                    }


                    ShowAllModel(modelMsr);
                    c.ModelId1 = ScannerManager.ReadInteger("Enter the Car's ID: ");

                    carMsr.Add(c);

                    goto case Menu.CarAll;

                case Menu.CarEdit:
                    Console.Clear();
                    ShowAllCar(carMsr);
                    Console.WriteLine("Change for Model's ID ==> 1 || Change for Year ==> 2 " +
                        "Change for Price ==> 3 || Change for Color ==> 4 " +
                        "Change for Engine ==> 5 || Change for FuelType ==> 6 " );
                    bool success2 = int.TryParse(Console.ReadLine(), out int menuNumber2);
                    if (success2 && menuNumber2 == 1)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        carMsr.CarEditModelId(value1);
                    }
                    else if (success2 && menuNumber2 == 2)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        carMsr.CarEditYear(value1);
                    }
                    else if (success2 && menuNumber2 == 3)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        carMsr.CarEditPrice(value1);
                    }
                    else if (success2 && menuNumber2 == 4)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        carMsr.CarEditColor(value1);
                    }
                    else if (success2 && menuNumber2 == 5)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        carMsr.CarEditEngine(value1);
                    }else if (success2 && menuNumber2 == 6)
                    {
                        int value1 = ScannerManager.ReadInteger("Enter the ID of choosen Model: ");
                        Console.Clear();
                        PrintFuelMenu();
                        carMsr.CarEditFuelType(value1);
                    }

                    goto case Menu.CarAll;

                case Menu.CarRemove:
                    Console.Clear();
                    ShowAllCar(carMsr);
                    int id2 = ScannerManager.ReadInteger("Silmek Istediyiniz Qrupun ID-ni Daxil Edin: ");

                    Car c1 = carMsr.GetAll().FirstOrDefault(item => item.CarId == id2);
                    carMsr.CarRemove(c1);
                    goto case Menu.CarAll;

                case Menu.CarSingle:
                    Console.Clear();
                    ShowAllCar(carMsr);
                    int idvalue2 = ScannerManager.ReadInteger("Enter the choosen Car: ");
                    brandMsr.BrandSingle(idvalue2);
                    goto ReadMenu;

                case Menu.CarAll:
                    Console.Clear();
                    ShowAllCar(carMsr);

                    goto ReadMenu;
                case Menu.All:
                    Console.Clear();
                    ShowAllBrand(brandMsr);
                    ShowAllModel(modelMsr);
                    ShowAllCar(carMsr);

                    goto ReadMenu;
                case Menu.Exit:
                    break;
                default:
                    break;
            }
            
        }

    static void PrintMenu()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));

            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Menu m = (Menu)Enum.Parse(typeof(Menu), item);

                Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
            }
            Console.WriteLine($"{new string('-', Console.WindowWidth)}\n");
        }

        static void PrintFuelMenu()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));

            foreach (var item in Enum.GetNames(typeof(FuelType)))
            {
                FuelType m = (FuelType)Enum.Parse(typeof(FuelType), item);

                Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
            }
            Console.WriteLine($"{new string('-', Console.WindowWidth)}\n");
        }

        static void ShowAllBrand(BrandManager brandManager)
        {
            Console.WriteLine("**********BRANDS************");
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        static void ShowAllCar(CarManager carManager)
        {
            Console.WriteLine("**********CARS**********");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        static void ShowAllModel(ModelManager modelManager)
        {
            Console.WriteLine("**********MODELS**********");
            foreach (var item in modelManager.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}

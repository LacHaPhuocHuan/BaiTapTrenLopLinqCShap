
using BaiLuyenTapLINQ_PhanPhuocHuan_21115053120315;
using System;
using System.Linq;

class Program
{
    
    static void Main(string[] args)
    {
      
         List<Car> cars = new List<Car>();
    List<Truck> trucks = new List<Truck>();
        
        var mf1 = new Manufactorer(1, "Manufacturer1");
        var mf3 = new Manufactorer(3, "Manufacturer3");
        var mf2 = new Manufactorer(2, "Manufacturer2");


        // Adding data for Car list
        cars.Add(new Car(4, 1, 150000.0f, DateTime.Now, "Car1",mf1));
        cars.Add(new Car(5, 2, 100000.0f, DateTime.Now, "Car2", mf2));
        cars.Add(new Car(6, 3, 280000.0f, DateTime.Now, "Car3", mf3));
        cars.Add(new Car(4, 4, 26000.0f, DateTime.Now, "Car4", mf1));
        cars.Add(new Car(5, 5, 32000.0f, DateTime.Now, "Car5", mf2));
        var cmp1 = new Company(1,"Company1");
        var cmp2 = new Company(2, "Company2");


        // Adding data for Truck list
        trucks.Add(new Truck(cmp1, 5000.0f, 1, 45000.0f, new DateTime(2002,1,2), "Truck1", mf1));
        trucks.Add(new Truck(cmp1, 8000.0f, 2, 60000.0f, new DateTime(2002, 1, 2), "Truck2",mf2));
        trucks.Add(new Truck(cmp2, 6000.0f, 3, 52000.0f, new DateTime(2002, 1, 2), "Truck3", mf1));
        trucks.Add(new Truck(cmp2, 7500.0f, 4, 48000.0f, new DateTime(2002, 1, 2), "Truck4", mf2));
        trucks.Add(new Truck(cmp2, 7000.0f, 5, 55000.0f, new DateTime(2002, 1, 2), "Truck5", mf3));

        while (true)
        {
            Console.WriteLine("Console Menu");
            Console.WriteLine("1. Hide cars which have price from 100.000 to 250.000");
            Console.WriteLine("2. Hide cars which have year of produce after 1990");
            Console.WriteLine("3. Group cars by manufactorer and compute value total");
            Console.WriteLine("4. Hide trucks  which have the latest year of produce ");
            Console.WriteLine("5. Hide owner company' name ");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice (1-6): ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You selected Option 1");
                    showOp01(cars);
                    continue;

                case "2":
                    Console.WriteLine("You selected Option 2");
                    showOp02(cars);
                    continue;

                case "3":
                    Console.WriteLine("You selected Option 3");
                    showOp03(cars);
                    continue;

                case "4":
                    Console.WriteLine("You selected Option 4");
                    showOp04(trucks);

                    continue;
                case "5":
                    Console.WriteLine("You selected Option 5");
                    showOp05(trucks);
                    continue;
                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    continue;
            }

            // Add a pause before displaying the menu again
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear(); // Clears the console screen for a cleaner display
        }

    }

    private static void showOp05(List<Truck> trucks)
    {
        List<String> ownerCompanyName = new List<string>();
        foreach(Truck truck in trucks)
        {
            if (!ownerCompanyName.Contains(truck.ownerCompany.name))
            
                ownerCompanyName.Add(truck.ownerCompany.name);
            
        }
        foreach(var name in ownerCompanyName)
        {
            Console.WriteLine(name);
        }

    }

    private static void showOp04(List<Truck> trucks)
    {
        var list=trucks.OrderBy(tr=> tr.dateOfProduct.Year).ToList();
        foreach(var truck in list)
        {
            truck.show();
        }
    }

    private static void showOp03(List<Car> cars)
    {
        Dictionary<Manufactorer, List<Car>> myDictionary = new Dictionary<Manufactorer, List<Car>>();

       

        for (int i = 0; i < cars.Count; i++)
        {
            var car = cars[i];

            if (!myDictionary.TryGetValue(car.manufactorer, out var carsOnMap))
            {
                myDictionary.Add(car.manufactorer, new List<Car> { car });
            }
            else
            {
                carsOnMap.Add(car);
            }

        }

        foreach (var kvp in myDictionary)
        {
            ShowOp03ForMfs(kvp);
        }
    }

    private static void ShowOp03ForMfs(KeyValuePair<Manufactorer, List<Car>> kvp)
    {
        var list = kvp.Value;
        float priceTotal = list.Sum(c => c.price);
        Console.Write("\n"+kvp.Key.name+": ");
        Console.Write(priceTotal+"\n");
        foreach (var car in list)
        {
            car.show();
        }

    }

    private static void showOp02(List<Car> cars)
    {
        var cars02 = cars.Where(c => c.dateOfProduct.Year>1990).ToList();
        for (int i = 0; i < cars02.Count; i++)
        {
            cars02[i].show();
        }
    }

    private static void showOp01(List<Car> cars)
    {
        var cars01 = cars.Where(c => c.price > 100000 && c.price < 250000).ToList();
        for(int i = 0;i<cars01.Count;i++)
        {
            cars01[i].show();
        }
       
    }
}
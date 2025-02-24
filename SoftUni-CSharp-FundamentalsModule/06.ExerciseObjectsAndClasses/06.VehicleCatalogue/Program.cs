namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                double horsePower = double.Parse(tokens[3]);
                
                vehicles.Add(new Vehicle(type, model, color, horsePower));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                if (vehicles.FirstOrDefault(x => x.Model == input) != null)
                {
                    Vehicle vehicle = vehicles.Find(x => x.Model == input);
                    Console.WriteLine(vehicle);
                }
            }


            double averageHorsePower = vehicles
                .Where(c => c.Type == "car")
                .Select(c => c.HorsePower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePower:F2}.");
                
            averageHorsePower = vehicles
                .Where(t => t.Type == "truck")
                .Select(t => t.HorsePower)
                .DefaultIfEmpty()
                .Average();
            
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePower:F2}.");
        }
    }
    
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        
        public override string ToString()
        {
            return $"Type: {FirstCharToUpper(Type)}\n"
                   + $"Model: {Model}\n"
                   + $"Color: {Color}\n"
                   + $"Horsepower: {HorsePower}";
        }
        
        public static string FirstCharToUpper(string type)  
        {  
            return char.ToUpper(type[0]) + type.Substring(1);  
        }  
    }
}

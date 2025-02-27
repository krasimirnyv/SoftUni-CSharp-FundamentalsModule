namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companiesMap = new Dictionary<string, Company>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companiesMap.ContainsKey(companyName))
                {
                    companiesMap.Add(companyName, new Company(companyName, employeeId));
                    continue;
                }

                if (!companiesMap[companyName].EmployeesIds.Contains(employeeId))
                {
                    companiesMap[companyName].EmployeesIds.Add(employeeId);
                }
            }

            foreach (KeyValuePair<string,Company> company in companiesMap)
            {
                Console.WriteLine($"{company.Key}\n" +
                                  $"{company.Value}");
            }
        }
    }

    class Company
    {
        public Company(string name, string employeeId)
        {
            Name = name;
            EmployeesIds = new List<string>{employeeId};
        }

        public string Name { get; set; }
        public List<string> EmployeesIds { get; set; }

        public override string ToString()
        {
            return $"-- {string.Join(Environment.NewLine + "-- ", EmployeesIds)}";
        }
    }
}

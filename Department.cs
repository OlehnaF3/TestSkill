namespace TestSkill
{
    class Department
    {
        public City City;
        public Company Company;

        public Department(City city, Company company)
        {
            City = city;
            Company = company;
        }

        public void WriteDepart() 
        {
            Console.WriteLine("At the bank {0} there is a branch in St. Petersburg",Company.Name);
        }

    }
    class Company
    {
        public string Type;
        public string Name;

        public Company(string type, string? name = null)
        {
            Type = type;
            Name = name??"Unknown company";
        }
    }
    class City
    {
        public string Name;

        public City(string name)
        {
            Name = name;
        }
    }
}

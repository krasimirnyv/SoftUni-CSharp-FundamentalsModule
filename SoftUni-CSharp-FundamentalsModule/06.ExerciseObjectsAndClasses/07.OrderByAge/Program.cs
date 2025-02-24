namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] elements = input.Split();
                
                string name = elements[0];
                string id = elements[1];
                uint age = uint.Parse(elements[2]);

                if (people.Exists(x => x.Id == id))
                {
                    Person person = people.Find(x => x.Id == id);
                    person.Name = name;
                    person.Age = age;
                }
                else
                {
                    people.Add(new Person(name, id, age));
                }
            }

            List<Person> sortedPeople = people.OrderBy(x => x.Age).ToList();
            foreach (Person person in sortedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, uint age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.".ToString();
        }
    }
}

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                
                students.Add(new Student(firstName, lastName, grade));
            }

            List<Student> sortedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}".ToString();
        }
    }
}

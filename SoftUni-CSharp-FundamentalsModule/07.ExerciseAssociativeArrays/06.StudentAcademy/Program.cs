namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Student(studentName, grade));
                    continue;
                }
                
                students[studentName].Grade.Add(grade);
            }

            Dictionary<string, Student> sortedStudents = students
                .Where(x => x.Value.TotalGrade >= 4.50)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string,Student> student in sortedStudents)
            {
                Console.WriteLine(student.Value);
            }
        }
    }

    class Student
    {
        public Student(string name, double grade)
        {
            Name = name;
            Grade = new List<double>{grade};
        }

        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double TotalGrade => Grade.Average();

        public override string ToString()
        {
            return $"{Name} -> {TotalGrade:F2}";
        }
    }
}

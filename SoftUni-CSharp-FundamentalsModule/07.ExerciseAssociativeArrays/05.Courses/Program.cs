namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ");
                string courseName = tokens[0];
                string studentName = tokens[1];
                
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new Course(courseName, studentName));
                    continue;
                }
                
                courses[courseName].Students.Add(studentName);
            }

            foreach (KeyValuePair<string,Course> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Students.Count}\n" +
                                  $"{course.Value}");
            }
        }
    }

    class Course
    {
        public Course(string name, string student)
        {
            Name = name;
            Students = new List<string>{student};
        }

        public string Name { get; set; }
        public List<string> Students { get; set; }

        public override string ToString()
        {
            return $"-- {string.Join(Environment.NewLine + "-- ", Students)}";
        }
    }
}
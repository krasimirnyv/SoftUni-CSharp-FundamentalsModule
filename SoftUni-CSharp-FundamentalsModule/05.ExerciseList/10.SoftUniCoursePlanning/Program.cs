using System;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            string commnad = string.Empty;
            while ((commnad = Console.ReadLine()) != "course start")
            {
                string[] tokens = commnad
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (tokens[0])
                {
                    case "Add":
                        string newLessonTitle = tokens[1];
                        AddingLesson(lessons, newLessonTitle);
                        break;
                    case "Insert":
                        newLessonTitle = tokens[1];
                        int index = int.Parse(tokens[2]);
                        InsertingLesson(lessons, newLessonTitle, index);
                        break;
                    case "Remove":
                        newLessonTitle = tokens[1];
                        RemovingLesson(lessons, newLessonTitle);
                        break;
                    case "Swap":
                        string firstLesson = tokens[1];
                        string secondLesson = tokens[2];
                        SwapingLesson(lessons, firstLesson, secondLesson);
                        break;
                    case "Exercise":
                        newLessonTitle = tokens[1];
                        AddExercise(lessons, newLessonTitle);
                        break;
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{++i}.{lessons[--i]}");
            }
        }
        
        private static void AddingLesson(List<string> lessons, string newLessonTitle)
        {
            if (!IsExist(lessons, newLessonTitle))
            {
                lessons.Add(newLessonTitle);
            }
        }
        
        private static void InsertingLesson(List<string> lessons, string newLessonTitle, int index)
        {
            if (!IsExist(lessons, newLessonTitle)
                && IsValidIndex(index, lessons))
            {
                lessons.Insert(index, newLessonTitle);
            }
        }

        private static void RemovingLesson(List<string> lessons, string newLessonTitle)
        {
            if (IsExist(lessons, newLessonTitle))
            {
                lessons.Remove(newLessonTitle);
            }
            
            if (IsExist(lessons, $"{newLessonTitle}-Exercise"))
            {
                lessons.Remove($"{newLessonTitle}-Exercise");
            }
        }
        
        private static void SwapingLesson(List<string> lessons, string firstLesson, string secondLesson)
        {
            if (IsExist(lessons, firstLesson) && IsExist(lessons, secondLesson))
            {
                int firstIndex = lessons.IndexOf(firstLesson);
                int secondIndex = lessons.IndexOf(secondLesson);
                
                lessons[firstIndex] = secondLesson;
                lessons[secondIndex] = firstLesson;

                string firstExercise = $"{firstLesson}-Exercise";
                string secondExercise = $"{secondLesson}-Exercise";

                if (IsExist(lessons, firstExercise))
                {
                    lessons.Remove(firstExercise);
                    lessons.Insert(secondIndex + 1, firstExercise);
                }

                if (IsExist(lessons, secondExercise))
                {
                    lessons.Remove(secondExercise);
                    lessons.Insert(firstIndex + 1, secondExercise);
                }
            }
        }

        private static void AddExercise(List<string> lessons, string newLessonTitle)
        {
            if (IsExist(lessons, newLessonTitle)
                && !IsExist(lessons, $"{newLessonTitle}-Exercise"))
            {
                int index = lessons.IndexOf(newLessonTitle);
                IfIndexIsNotInRangeAddIt(lessons, newLessonTitle, index);
            }
            else if (!IsExist(lessons, newLessonTitle)
                     && !IsExist(lessons, $"{newLessonTitle}-Exercise"))
            {
                lessons.Add(newLessonTitle);
                lessons.Add($"{newLessonTitle}-Exercise");
            }
        }

        private static void IfIndexIsNotInRangeAddIt(List<string> lessons, string newLessonTitle, int index)
        {
            int exerciseIndex = index + 1;
            if (exerciseIndex < lessons.Count)
            {
                lessons.Insert(exerciseIndex, $"{newLessonTitle}-Exercise");
            }
            else if (exerciseIndex == lessons.Count)
            {
                lessons.Add($"{newLessonTitle}-Exercise");
            }
        }

        private static bool IsExist(List<string> lessons, string lessonTitle)
        {
            return lessons.Contains(lessonTitle);
        }
        
        private static bool IsValidIndex(int index, List<string> lessons)
        {
            return index >= 0 && index < lessons.Count;
        }
    }
}

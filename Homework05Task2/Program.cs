using System;

namespace Homework05Task2
{
    class Program

    {
        public class FirstCourse
        {
            public FirstCourse(string courseName, bool pass)
            {
                CourseName = courseName;
                passed = pass;
            }

            public bool Passed()
            {
                if (passed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string CourseName;
            public bool passed;
        }

        public class SecondCourse
        {
            public SecondCourse(string courseName, StudentGrades grade)
            {
                CourseName = courseName;
                Grades = grade;
            }

            public string CourseName;
            public StudentGrades Grades;

            public bool Passed()
            {
                if ((int)Grades != 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class Project
        {
            public Project(bool courseOne, bool courseTwo, bool courseThree, bool courseFour)
            {
                CourseOne = courseOne;
                CourseTwo = courseTwo;
                CourseThree = courseThree;
                CourseFour = courseFour;
            }

            bool CourseOne;
            bool CourseTwo;
            bool CourseThree;
            bool CourseFour;

            public void Passed()
            {
                bool[] array = { CourseOne, CourseTwo, CourseThree, CourseFour };
                int sumOfCourses = 0;

                foreach (var item in array)
                {
                    if (item == true)
                    {
                        sumOfCourses++;
                    }
                }
                if (sumOfCourses > 2)
                {
                    Console.WriteLine($"Student has passed, successifully achieving {sumOfCourses} courses! "); ;
                }
                else
                {
                    Console.WriteLine("Studend failed!"); ;
                }

                public enum StudentGrades
            { 
                Ten = 10,
                Nine = 9,
                Eight = 8,
                Seven = 7,
                Six = 6,
                Five = 5
            }
        }
            static void Main(string[] args)
        {
            var firstCourseOne = new FirstCourse("Math", true);
            var firstCourseTwo = new FirstCourse("Programming", true);

            var secondCourseOne = new SecondCourse("Algorithms", StudentGrades.Ten);
            var seocndCourseTwo = new SecondCourse("Scrum Master", StudentGrades.Six);

            Project Grades = new Project(firstCourseOne.Passed(), firstCourseTwo.Passed(), secondCourseOne.Passed(), seocndCourseTwo.Passed());

            Grades.Passed();

            Console.ReadLine();

        }
    }
}

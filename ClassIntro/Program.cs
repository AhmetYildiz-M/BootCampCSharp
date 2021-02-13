using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Engin";
            int age = 36;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instractor = "Engin Demiroğ";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instractor = "Kerem Varış";
            course2.ViewRate = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instractor = "Berkay Bilgin";
            course3.ViewRate = 80;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Instractor = "Murat Kurtboğan";
            course4.ViewRate = 100;




            //Console.WriteLine(course1.CourseName + " : " + course1.Instractor);

            Course[] courses = new Course[] { course1, course2, course3, course4 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Instractor);
            }


        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Instractor { get; set; }
        public int ViewRate { get; set; }
    }
}

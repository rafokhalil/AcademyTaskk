using System;

namespace Academy
{
    class Runer
    {
        public static void Run()
        {
            Random random = new Random();
            int count = 6;
            int[] scores = new int[count];
            for (int i = 0; i < count; i++)
            {
                scores[i] = random.Next(17, 100);
            }

            Exam exam1 = new Exam
            {
                Lesson = "C++",
                Score = scores[0],
                ExamTime = new DateTime(2021, 06, 25, 09, 00, 00)
            };

            Exam exam2 = new Exam
            {
                Lesson = "C++",
                Score = scores[1],
                ExamTime = new DateTime(2021, 06, 25, 09, 40, 00)
            };

            Exam exam3 = new Exam
            {
                Lesson = "C++",
                Score = scores[2],
                ExamTime = new DateTime(2021, 06, 25, 10, 20, 00)
            };


            Exam exam4 = new Exam
            {
                Lesson = "C++",
                Score = scores[3],
                ExamTime = new DateTime(2021, 06, 20, 14, 00, 00)
            };


            Exam exam5 = new Exam
            {
                Lesson = "C++",
                Score = scores[4],
                ExamTime = new DateTime(2021, 06, 20, 14, 50, 00)
            };

            Exam exam6 = new Exam
            {
                Lesson = "C++",
                Score = scores[5],
                ExamTime = new DateTime(2021, 06, 20, 15, 30, 00)
            };

            Student student1 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Rafael",
                Surname = "Xelilzade",
                Age = 17,
                Email = "rafaelxelilzade01@gmail.com",
                Exam = exam1
            };

            Student student2 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Kamran",
                Surname = "Aliyev",
                Age = 23,
                Email = "aliyev.009@gmail.com",
                Exam = exam2
            };

            Student student3 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Ruslan",
                Surname = "Mustafayev",
                Age = 20,
                Email = "rafaelxelilzade01@gmail.com",
                Exam = exam3
            };

            Student student4 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Huseyn",
                Surname = "Rustemli",
                Age = 20,
                Email = "rafaelxelilzade01@gmail.com",
                Exam = exam4
            };

            Student student5 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Vaqif",
                Surname = "Ismayilov",
                Age = 18,
                Email = "rafaelxelilzade01@gmail.com",
                Exam = exam5
            };


            Student student6 = new Student
            {
                ID = Guid.NewGuid(),
                Name = "Ayaz",
                Surname = "Nebiyev",
                Age = 20,
                Email = "rafaelxelilzade01@gmail.com",
                Exam = exam6
            };

            Group group1 = new Group
            {
                GroupName = "2201",
                Tutor = "Pervane ",
            };

            group1.AddStudent(ref student1);
            group1.AddStudent(ref student2);
            group1.AddStudent(ref student3);

            Group group2 = new Group
            {
                GroupName = "2203",
                Tutor = "Pervane",
            };
            group2.AddStudent(ref student4);
            group2.AddStudent(ref student5);
            group2.AddStudent(ref student6);

            Teacher teacher1 = new Teacher
            {
                TeacherName = "Elvin Camalzade",
                TeacherExprience = "6 years exprience",
            };
            teacher1.AddGruop(ref group1);
            Teacher teacher2 = new Teacher
            {
                TeacherName = "Kamran Aliyev",
                TeacherExprience = "4 years exprience",
            };
            teacher2.AddGruop(ref group2);
            Academy academy = new Academy
            {
                AcademyName = "IT Step Academy",
            };
            academy.AddTeacher(ref teacher1);
            academy.AddTeacher(ref teacher2);
        label:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("================MAIN MENU================");
            Console.WriteLine("1. Show Academy  ");
            Console.WriteLine("2. Exam ");
            Console.ResetColor();
            var coming = Console.ReadLine();
            int b = int.Parse(coming);
            if (b == 1)
            {
                Console.Clear();
                academy.ShowAcademy();
            }
            else if (b == 2)
            {
                Console.Clear();
                teacher1.StartExam("C#", "2201");
                teacher2.StartExam("C++", "2203");
            }
            else
            {
                Console.Clear();
                goto label;
            }
        }
    }
}

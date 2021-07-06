using System;
namespace Academy
{
    class Exam
    {
        public string Lesson { get; set; }
        public int Score { get; set; }
        public DateTime ExamTime { get; set; }
        public void ShowExam()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================Exam===============");
            Console.WriteLine($"Lesson :{Lesson} ");
            if (Score > 90)
            {
                Console.WriteLine($"Score :{Score}  A(perfect)");
            }
            else if (Score > 80)
            {
                Console.WriteLine($"Score :{Score}  B(very good)");
            }
            else if (Score > 70)
            {
                Console.WriteLine($"Score :{Score}  C(good)");
            }
            else if (Score > 60)
            {
                Console.WriteLine($"Score :{Score}  D(enough)");
            }
            else if (Score > 50)
            {
                Console.WriteLine($"Score :{Score}  E(insufficient)");
            }
            else if (Score > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Score :{Score}  F(Failed)");
                Console.WriteLine("You failed the Exam :( ");
                Console.ResetColor();
            }
            else
            {
                throw new Exception("Score can not negative");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Exam Time :{ExamTime} ");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

using System;
using System.IO;
using System.Threading;
namespace Academy
{
    class Teacher
    {
        public string TeacherName { get; set; }
        public string TeacherExprience { get; set; }
        public Group[] groups { get; set; }
        public int CountGroup { get; set; }
        public static void WriteBlinkingText(string text, int delay, bool visible)
        {
            if (visible)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text);
                Console.ResetColor();
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(" ");
                }
            }
            Console.CursorLeft -= text.Length;
            System.Threading.Thread.Sleep(delay);
        }
        public void StartExam(string lesson_name, string group_name)
        {
            foreach (var gr in groups)
            {
                if (gr.GroupName == group_name)
                {
                    string fileName = "Exam.txt";
                    string path = Path.Combine(Environment.CurrentDirectory, fileName);
                    string txt1 = "Exam begin !!! ";
                    int count = 3;
                    while (count != 0)
                    {
                        WriteBlinkingText(txt1, 500, true);
                        WriteBlinkingText(txt1, 500, false);
                        count--;
                    }
                    foreach (var st in gr.students)
                    {
                        string txt2 = "Exam is lasted";
                        int count1 = 6;
                        while (count1 != 0)
                        {
                            WriteBlinkingText(txt2, 500, true);
                            WriteBlinkingText(txt2, 500, false);
                            count1--;
                        }

                        if (st.Exam.Score > 90)
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} A(Perfect) from {lesson_name} ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulation");
                            Thread.Sleep(870);
                            File.AppendAllText(path, $" Name : { st.Name}, Surame : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name} {st.Surname} your Score is {st.Exam.Score}");
                        }
                        else if (st.Exam.Score > 80)
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} B(Very Good) from {lesson_name} on {st.Exam.ExamTime}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulation");
                            Thread.Sleep(870);

                            File.AppendAllText(path, $" Name : { st.Name}, Surame : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name} {st.Surname}   your Score is {st.Exam.Score}");
                        }
                        else if (st.Exam.Score > 70)
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} C(Good) from {lesson_name} on {st.Exam.ExamTime}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulation");
                            Thread.Sleep(870);
                            File.AppendAllText(path, $" Name : { st.Name}, Surame : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name}   {st.Surname} your Score is {st.Exam.Score}");
                        }
                        else if (st.Exam.Score > 60)
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} D(Enough) from {lesson_name} on {st.Exam.ExamTime}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulation");
                            Thread.Sleep(870);
                            File.AppendAllText(path, $" Name : { st.Name}, Surame : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name} {st.Surname} your Score is {st.Exam.Score}");
                        }
                        else if (st.Exam.Score > 50)
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} E(Insufficient) from {lesson_name} on {st.Exam.ExamTime}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulation");
                            Thread.Sleep(870);
                            File.AppendAllText(path, $" Name : { st.Name}, Surame : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name}  {st.Surname} your Score is {st.Exam.Score}");
                        }
                        else
                        {
                            Console.WriteLine($"{st.Name}  {st.Surname} ,Your Score is {st.Exam.Score} F(Failed) from {lesson_name} on {st.Exam.ExamTime}");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Sorry,You failed from {lesson_name} Exam :( good luck for future Exam ");
                            Thread.Sleep(870);
                            File.AppendAllText(path, $" Name : { st.Name}, Surname : { st.Surname},  Score is { st.Exam.Score }, {st.Exam.ExamTime}\n");
                            Thread.Sleep(870);
                            Mail.SendMail(st.Email, $"Dear student {st.Name}", $"Dear student {st.Name}  {st.Surname} your Score is {st.Exam.Score} (F) Please Study Carefully ");
                        }
                        Console.WriteLine();
                        Console.ResetColor();
                    }

                }
            }
        }
        public void AddGruop(ref Group group)
        {
            var temp = new Group[++CountGroup];
            if (groups != null)
            {
                groups.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = group;
            groups = temp;
        }
        public void ShowTeacher()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("======Teacher======");
            Console.WriteLine($"Teacher Name : {TeacherName} ");
            Console.WriteLine($"Teacher Exprience : {TeacherExprience} ");
            foreach (var Gp in groups)
            {
                Gp.ShowGroup();
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

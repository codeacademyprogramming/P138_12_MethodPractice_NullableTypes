using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Abbas Abbasov", "Tofiq Rehumov", "Nermin Abbaszade" };
            string opt;
            do
            {
                Console.WriteLine("\n1. Telebelere bax");
                Console.WriteLine("2. Telebe elave et");
                Console.WriteLine("3. Telebelere uzre axtaris et");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Elave temek istediyiniz telebeni daxil edin:");
                        string std = Console.ReadLine();
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;

                        break;
                    case "3":
                        Console.WriteLine("Telebeleri uzre axtaris et");
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir, yeniden cehd edin!");
                        break;
                }
                

            } while (opt != "0");

           



        }
    }
}

using System;

namespace P223FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataType,Variable
            //int num = 10;
            //string name = "kamran";
            //bool ismarried = true;
            //decimal pi = 3.14m;
            //Console.WriteLine(num);

            //var num = 10;
            //num = 100;
            //dynamic word = "Hello";
            //word = 10;
            //word = new { };
            #endregion

            //int age = 18;
            //string city = "Baku";
            //if (age>16)
            //{
            //    if (city == "Baku")
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //}

            //int day = 5;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //    case 5:
            //        break;
            //    case 6:
            //        Console.WriteLine("4 5 6");
            //        break;
            //    default:
            //        Console.WriteLine("Other day");
            //        break;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //} while (i != 1);

            //for (;;)
            //{
            //    Console.WriteLine("Hello");
            //}

            try
            {
                Console.WriteLine("Eded daxil edin:");
                string a = Console.ReadLine();
                int num = int.Parse(a);
                Console.WriteLine("eded: " + num);
            }
            catch (Exception)
            {
                Console.WriteLine("Sehv daxil etdiniz");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            
        }
    }
}

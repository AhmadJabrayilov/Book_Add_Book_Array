using System;
using Class_Book_Array.Models;
namespace Class_Book_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookUnit = GetInputInt("Nece kitab alacaqsiniz?", 1, 30);

            Book[] books = new Book[bookUnit];

            for (int i = 0; i < bookUnit; i++)
            {
                int No = GetInputInt("Aldiginiz kitabin nomresi ",0);

                string name = GetStringInput($"{No}. Kitabin  adi:",1);

                double price = GetDoubleInput($"{No}. Kitabin qiymeti: ", 0);

                string genre = GetStringInput($"{No}. Kitabin  Janri:", 0);

                books[i] = new Book(genre,No,name,price,No);
                //{
                //    genre = genre;
                //    name = name;
                //    price = price;  
                    
                //}
            }

            Console.WriteLine("emeliyyatlardan birini secin");
            for (int i = 0; i <= 3; i++)
            {
                int emeliyyat = Convert.ToInt32(Console.ReadLine());
                if (emeliyyat == 2)
                {
                    foreach (var item in books)
                    {
                        Console.WriteLine($"Name: {item.name} / No: {item.No}");
                    }
                }

                if (emeliyyat == 3)
                {
                    break;
                }
            }
        }


        static int GetInputInt(string name, int min, int max = int.MaxValue)
        {
            int input;

            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);

            return input;   
        }

        static string GetStringInput(string name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
            }
            while(input.Length < min || input.Length > max);

            return input;
        }
        
        static double GetDoubleInput(string name, double min, double max = double.MaxValue)
        {
            double input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToDouble(Console.ReadLine());   
            }
            while(input< min || input > max);

            return input;
        }



    }
}

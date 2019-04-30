using System.Collections;
using System.Collections.Generic;
using System;

namespace ConsoleApplication1.ASM4
{
    public class Program
    {
        public static void InsertNews()
        {
            
        }
        
        
        public static void Add(News data)
        {
            Console.WriteLine("Enter ID :");
            int ID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title :");
            string Title = Console.ReadLine();
            Console.WriteLine("PublishDate");
            string PublishDate = Console.ReadLine();
            Console.WriteLine("Author");
            String Author = Console.ReadLine();
            Console.WriteLine("Content");
            String Content = Console.ReadLine();
            Console.WriteLine("AverageRate ");
            float diemTBcong = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3 numbers: ");
            int no1 = Int32.Parse(Console.ReadLine());
            int no2 = Int32.Parse(Console.ReadLine());
            int no3 = Int32.Parse(Console.ReadLine());
            int[] RateList = { no1, no2, no3 };
            data.Add(new News(ID, Title, PublishDate, Author, Content, RateList));
            
        }
        
        public static void Menu()
        {
            Console.WriteLine("1:Insert news");
            Console.WriteLine("2:View list news");
            Console.WriteLine("3:Average rate");
            Console.WriteLine("4:Exit");
        }
        
        public static void Main3(string[] args)
        {
            News data = new News();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1:Insert news");
                Console.WriteLine("2:View list news");
                Console.WriteLine("3:Average rate");
                Console.WriteLine("4:Exit");
                
                Console.WriteLine("Enter your choice:");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        Add(data);
                        Menu();
                        break;
                    case 2:
                        data.Display();
                        break;
                    case 3: 
                        data.Calculate();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public class StartUp
    {
        public void PrintChoise()
        {
            BookRepositoty bookRepositoty = new BookRepositoty();
            
            GOTOHERE:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MongoDB. Book database inc.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(">Type '1' to add book.");
            Console.WriteLine("");
            Console.WriteLine(">Type '2' to delete book.");
            Console.WriteLine("");
            Console.WriteLine(">Type '3' to find the book by name.");
            Console.WriteLine("");
            Console.WriteLine(">Type '4' to edit book name.");
            var result = Convert.ToInt32(Console.ReadLine());
            
            
            if (result == 1)
            {
                bookRepositoty.CreateBook();
            }
            else if (result == 2)
            {
                bookRepositoty.DeleteBook();
            }
            else if (result == 3)
            {
                bookRepositoty.FindBook();
            }
            else if (result == 4)
            {
                bookRepositoty.EditBookName();
            } 
            
            else
            {
               Console.WriteLine("Enter a valid number and press ENTER...");
               System.Threading.Thread.Sleep(2000);
               goto GOTOHERE;
            }
        }
    }
}

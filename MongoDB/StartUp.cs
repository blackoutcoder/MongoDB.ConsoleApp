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
            Console.WriteLine("--Type 1 to add book--  --Type 2 to delete book--");
            var result = Convert.ToInt32(Console.ReadLine());
            if(result == 1)
            {
                bookRepositoty.CreateBook();
            } 
            else if (result == 2)
            {
                bookRepositoty.DeleteBook();
            }
        }
    }
}

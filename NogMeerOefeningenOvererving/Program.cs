using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOefeningenOvererving
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Console.WriteLine(TelOp(book1, book2).ToString());
            Console.ReadLine();
        }
        static Book TelOp(Book book1, Book book2) 
        {

            Book temp = new Book();
            temp.Author = $"{book1.Author},{book2.Author}";
            temp.Title = $"Omnibus van {temp.Author}";
            temp.Price = (book1.Price + book2.Price) / 2;
            return temp;

        }
    }
}

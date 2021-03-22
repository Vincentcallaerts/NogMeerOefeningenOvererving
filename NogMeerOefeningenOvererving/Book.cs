using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOefeningenOvererving
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        private double price;
        public Book()
        {
            ISBN = 123456;
            Title = "Yolo";
            Author = "69420";

        }
        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            return $"{Title}-{Author}({ISBN}) {Price}";
        }
        public override bool Equals(object obj)
        {
            Book book = (Book)obj;

            return (ISBN == book.ISBN);
        }
    }
}

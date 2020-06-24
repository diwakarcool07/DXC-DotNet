using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{
    class BookStore
    {
        public int bookno;
        public string bookName;
        public string bookTitle;
        public string bookAuthor;
        public int bookQuantity;
        public double bookPrice;
        public void Details()
        {
            Console.WriteLine("BookNumber: " + bookno);
            Console.WriteLine("Bookname: " + bookName);
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("BookAuthor: " + bookAuthor);
            Console.WriteLine("BookQuantity: " + bookQuantity);
            Console.WriteLine("Book Price: " + bookPrice);
        }

        public double ammountPayable(int qty,double price)
        {
            double totalprice = qty * price;
            return totalprice;

        }
    }

    class Test_Book
    {
        static void Main()
        {
            BookStore bs = new BookStore();
            bs.bookno = 101;
            bs.bookName = "C# Programming";
            bs.bookTitle = "Programming";
            bs.bookAuthor = "Diwakar";
            bs.bookQuantity = 10;
            bs.bookPrice = 717;
            bs.Details();
            Console.WriteLine("Total price is to be paid is "+bs.ammountPayable(bs.bookQuantity,bs.bookPrice));
            Console.ReadKey();
        }
    }
}

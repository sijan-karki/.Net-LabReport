// Simple c# program to demonstrate the Structuer in c#
using System;
namespace LabReport_Csit_SijanKarki
{
    class StructDemo
    {
        struct Book
        {
            public string bookName;
            public string authorName;
            public Book(string bookName, string authorName)
            {
                this.bookName = bookName;
                this.authorName = authorName;
            }
            public void display()
            {
                Console.WriteLine("The author of {0} is {1}", bookName, authorName);
            }

        }

        static void Main(string[] args)
        {
            Book b1 = new Book("C#", "Bipin Timilsina");
            Book b2 = new Book("Technical Writing", "Rajan Adhakari");
            b1.display();
            b2.display();
        }
    }
}

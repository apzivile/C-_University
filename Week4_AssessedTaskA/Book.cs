using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar4A
{
    class Book : IComparable
    {
        public string ISBN;
        public string Title;
        public string Author;

        public Book(string ISBN, string Title, string Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }
        public override string ToString()
        {
            return Title + " " + Author + " " + ISBN;
        }
        public int CompareTo(object obj)
        {
            Book b = (Book)obj;
            return this.ISBN.CompareTo(b.ISBN); // sort by isbn, change ISBN to title or author to change how to sort
        }
    }
}

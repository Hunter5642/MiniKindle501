using System;
using System.Collections.Generic;
using System.Text;

namespace MiniKindle501
{
    public class Library
    {
        private List<Book> library = new List<Book>();

        public Library(List<Book> books)
        {
            library = books;
        }
    }
}

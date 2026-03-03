using System;
using System.Collections.Generic;
using System.Text;

namespace MiniKindle501
{
    public class KindleModel
    {
        private Library library;
        private Book currentBook;
        public List<int> bookmarks;

        public KindleModel(Book b)
        {
            currentBook = b;
            bookmarks = new List<int>();
            library = new Library(new List<Book> { b });
        }

        public int GetCurrentPage()
        {
            return currentBook.CurrentPage;
        }

        public Book GetCurrentBook()
        {
            return currentBook;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MiniKindle501
{
    public class KindleModel
    {
        private Library library;
        private Book currentBook;

        public int CurrentPage;
        public int PageCount;
        public string? CurrentPageText;
        public List<int> bookmarks;

        public KindleModel(Book b)
        {
            currentBook = b;
            bookmarks = new List<int>();
            library = new Library(new List<Book> { b });

            SyncFromBook();
        }

        public void SyncFromBook()
        {
            CurrentPage = currentBook.GetCurrentPage();
            PageCount = currentBook.GetPageCount();
            CurrentPageText = currentBook.GetPageText();
        }

        public int GetCurrentPage() { return CurrentPage; }
        public Book GetCurrentBook() { return currentBook; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MiniKindle501
{
    public class Book
    {
        private int currentPage;
        private List<string> pages;
        private string author;

        public Book()
        {
            currentPage = 0;
            pages = new List<string>();
            author = "";
        }

        public void AddRemBkMk(int p, bool a, List<int> bookmarks)
        {
            if (a)
            {
                bookmarks.Add(p);
            }
            else
            {
                bookmarks.Remove(p);
            }
        }

        public void FlipPage(int dir)
        {
            int newPage = currentPage + dir;
            if (newPage >= 0 && newPage < pages.Count)
            {
                currentPage = newPage;
            }
        }

        public int GetCurrentPage() { return currentPage; }
        public int GetPageCount() { return pages.Count; }
        public string GetPageText() { return pages[currentPage]; }
        public string GetAuthor() { return author; }
        public void SetAuthor(string a) { author = a; }
        public void AddPage(string text) { pages.Add(text); }
    }
}

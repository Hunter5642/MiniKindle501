using System;
using System.Collections.Generic;
using System.Text;

namespace MiniKindle501
{
    public class Book
    {
        public int CurrentPage;
        public List<string> Pages;
        public string Author;

        public Book()
        {
            CurrentPage = 0;
            Pages = new List<String>();
            Author = "";
        }

        public void AddRemBkmk(int p, bool a, List<int> bookmarks)
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
            int newPage = CurrentPage + dir;
            if (newPage >= 0 && newPage < Pages.Count)
            {
                CurrentPage = newPage;
            }
        }
    }
}

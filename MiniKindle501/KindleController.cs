using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static MiniKindle501.Program;

namespace MiniKindle501
{
    public class KindleController
    {
        private KindleModel model;
        private List<ObserverDel> observerList;

        public KindleController(KindleModel m)
        {
            model = m;
            observerList = new List<ObserverDel>();
        }

        public void HandleFlip(int dir)
        {
            model.GetCurrentBook().FlipPage(dir);
            UpdateObs();
        }

        public void HandleAddBookmark()
        {
            if (ValidateBookmark())
            {
                model.GetCurrentBook().AddRemBkmk(model.GetCurrentPage(), true, model.bookmarks);
                UpdateObs();
            }
            
        }
        public void HandleRemoveBookmark()
        {
            if (model.bookmarks.Contains(model.GetCurrentPage()))
            {
                model.GetCurrentBook().AddRemBkmk(model.GetCurrentPage(), false, model.bookmarks);
                UpdateObs();
            }
        }

        public void RegisterObs(ObserverDel o)
        {
            observerList.Add(o);
        }

        private void UpdateObs()
        {
            foreach (ObserverDel o in observerList)
            {
                o();
            }
        }

        private bool ValidateBookmark()
        {
            bool alreadyBookmarked = model.bookmarks.Contains(model.GetCurrentPage());
            return model.bookmarks.Count < 5 && !alreadyBookmarked;
        }
    }
}

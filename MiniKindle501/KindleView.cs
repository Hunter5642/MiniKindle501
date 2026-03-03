using static MiniKindle501.Program;

namespace MiniKindle501
{
    public partial class KindleView : Form
    {
        private KindleModel model;
        private FlipInputDel flipDel;
        private BkmkInputDel addBkmkDel;
        private BkmkInputDel remBkmkDel;

        public KindleView(KindleModel m, FlipInputDel hf, BkmkInputDel ha, BkmkInputDel fr)
        {
            model = m;
            flipDel = hf;
            addBkmkDel = ha;
            remBkmkDel = fr;

            InitializeComponent();
            UpdateGUI();
        }

        // clear page, get current page, get bookmarks
        public void UpdateGUI()
        {
            Book currentBook = model.GetCurrentBook();

            pageTextLabel.Text = currentBook.Pages[currentBook.CurrentPage];
            int pageNum = currentBook.CurrentPage + 1;
            pageNumLabel.Text = "Page " + pageNum + " / " + currentBook.Pages.Count;

            UpdateBookmarkIndicator();
        }

        private void UpdateBookmarkIndicator()
        {
            if (model.bookmarks.Contains(model.GetCurrentPage()))
            {
                bookmarkIndicatorLabel.Text = "Bookmarked";
                bookmarkIndicatorLabel.ForeColor = Color.Gold;
            }
            else
            {
                bookmarkIndicatorLabel.Text = "Not bookmarked";
                bookmarkIndicatorLabel.ForeColor = Color.Gray;
            }
        }

        private void FlipBackbtn_Click(object sender, EventArgs e)
        {
            flipDel(-1);
        }

        private void FlipForbtn_Click(object sender, EventArgs e)
        {
            flipDel(1);
        }

        private void AddBkmkbtn_Click(object sender, EventArgs e)
        {
            addBkmkDel();
        }

        private void RemBkmarkbtn_Click(object sender, EventArgs e)
        {
            remBkmkDel();
        }
    }
}

namespace MiniKindle501
{
    public static class Program
    {
        public delegate void FlipInputDel(int dir);

        public delegate void BkmkInputDel();
        
        public delegate void ObserverDel();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Book book = new Book();
            book.Pages.Add("Welcome to MiniKindle!");
            book.Pages.Add("This is page 2.");
            book.Pages.Add("This is page 3.");
            book.Pages.Add("This is page 4.");
            book.Pages.Add("This is page 5.");
            book.Pages.Add("This is page 6.");

            KindleModel model = new KindleModel(book);
            KindleController c = new KindleController(model);
            KindleView v = new KindleView(model, c.HandleFlip, c.HandleAddBookmark, c.HandleRemoveBookmark);

            c.RegisterObs(v.UpdateGUI);

            Application.Run(v);
        }
    }
}
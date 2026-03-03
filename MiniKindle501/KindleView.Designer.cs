namespace MiniKindle501
{
    partial class KindleView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageTextLabel = new Label();
            pageNumLabel = new Label();
            bookmarkIndicatorLabel = new Label();
            FlipBackbtn = new Button();
            AddBkmkbtn = new Button();
            RemBkmarkbtn = new Button();
            FlipForbtn = new Button();
            SuspendLayout();
            // 
            // pageTextLabel
            // 
            pageTextLabel.AutoSize = true;
            pageTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pageTextLabel.Location = new Point(12, 31);
            pageTextLabel.Name = "pageTextLabel";
            pageTextLabel.Size = new Size(69, 21);
            pageTextLabel.TabIndex = 0;
            pageTextLabel.Text = "PageText";
            // 
            // pageNumLabel
            // 
            pageNumLabel.AutoSize = true;
            pageNumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pageNumLabel.Location = new Point(718, 414);
            pageNumLabel.Name = "pageNumLabel";
            pageNumLabel.Size = new Size(34, 21);
            pageNumLabel.TabIndex = 1;
            pageNumLabel.Text = "0/0";
            // 
            // bookmarkIndicatorLabel
            // 
            bookmarkIndicatorLabel.AutoSize = true;
            bookmarkIndicatorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookmarkIndicatorLabel.Location = new Point(660, 9);
            bookmarkIndicatorLabel.Name = "bookmarkIndicatorLabel";
            bookmarkIndicatorLabel.Size = new Size(128, 21);
            bookmarkIndicatorLabel.TabIndex = 2;
            bookmarkIndicatorLabel.Text = "Not bookmarked";
            // 
            // FlipBackbtn
            // 
            FlipBackbtn.Location = new Point(12, 415);
            FlipBackbtn.Name = "FlipBackbtn";
            FlipBackbtn.Size = new Size(75, 23);
            FlipBackbtn.TabIndex = 3;
            FlipBackbtn.Text = "<--";
            FlipBackbtn.UseVisualStyleBackColor = true;
            FlipBackbtn.Click += FlipBackbtn_Click;
            // 
            // AddBkmkbtn
            // 
            AddBkmkbtn.Location = new Point(397, 415);
            AddBkmkbtn.Name = "AddBkmkbtn";
            AddBkmkbtn.Size = new Size(109, 23);
            AddBkmkbtn.TabIndex = 4;
            AddBkmkbtn.Text = "Add Bookmark";
            AddBkmkbtn.UseVisualStyleBackColor = true;
            AddBkmkbtn.Click += AddBkmkbtn_Click;
            // 
            // RemBkmarkbtn
            // 
            RemBkmarkbtn.Location = new Point(531, 415);
            RemBkmarkbtn.Name = "RemBkmarkbtn";
            RemBkmarkbtn.Size = new Size(116, 23);
            RemBkmarkbtn.TabIndex = 5;
            RemBkmarkbtn.Text = "Remove Bookmark";
            RemBkmarkbtn.UseVisualStyleBackColor = true;
            RemBkmarkbtn.Click += RemBkmarkbtn_Click;
            // 
            // FlipForbtn
            // 
            FlipForbtn.Location = new Point(110, 415);
            FlipForbtn.Name = "FlipForbtn";
            FlipForbtn.Size = new Size(75, 23);
            FlipForbtn.TabIndex = 6;
            FlipForbtn.Text = "-->";
            FlipForbtn.UseVisualStyleBackColor = true;
            FlipForbtn.Click += FlipForbtn_Click;
            // 
            // KindleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FlipForbtn);
            Controls.Add(RemBkmarkbtn);
            Controls.Add(AddBkmkbtn);
            Controls.Add(FlipBackbtn);
            Controls.Add(bookmarkIndicatorLabel);
            Controls.Add(pageNumLabel);
            Controls.Add(pageTextLabel);
            Name = "KindleView";
            Text = "KindleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageTextLabel;
        private Label pageNumLabel;
        private Label bookmarkIndicatorLabel;
        private Button FlipBackbtn;
        private Button AddBkmkbtn;
        private Button RemBkmarkbtn;
        private Button FlipForbtn;
    }
}

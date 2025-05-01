namespace FileTreeSize
{
    partial class Form1
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
            button1 = new Button();
            listView1 = new ListView();
            Size = new ColumnHeader();
            Type = new ColumnHeader();
            Name = new ColumnHeader();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "btnSelectFolder";
            button1.BackColor = Color.SeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 0;
            button1.Text = "Scan Folder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseCaptureChanged += button1_Click;
            // 
            // listView1
            // 
            listView1.AccessibleName = "listView1";
            listView1.Columns.AddRange(new ColumnHeader[] { Name, Size, Type });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 66);
            listView1.Name = "listView1";
            listView1.Size = new Size(484, 226);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Size
            // 
            Size.Text = "Size";
            Size.TextAlign = HorizontalAlignment.Center;
            Size.Width = 100;
            // 
            // Type
            // 
            Type.Text = "Type";
            Type.TextAlign = HorizontalAlignment.Center;
            Type.Width = 100;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private ColumnHeader Size;
        private ColumnHeader Type;
        private ColumnHeader Name;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}

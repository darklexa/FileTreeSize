using System.IO;
using System.Linq; // Add this for OrderByDescending



namespace FileTreeSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;
                listView1.Items.Clear(); //clear previous results

                DirectoryScanner scanner = new DirectoryScanner();
                var entries = scanner.ScanFolder(selectedPath);

                foreach (var entry in entries.OrderByDescending(e => e.Size))
                {
                    ListViewItem item = new ListViewItem(entry.Name);
                    item.SubItems.Add($"{entry.Size / 1024.0:F2} KB");
                    item.SubItems.Add(entry.Type);
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

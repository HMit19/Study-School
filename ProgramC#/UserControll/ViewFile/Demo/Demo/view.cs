using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class view : UserControl
    {
        private string path;

        public string Path {
            get { return path; }
            set { path = value; }
        }

        public view()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.path = cb1.Text;
            foreach (string item in listView.Items) {
                if (!item.Equals(cb1.Text))
                {
                    cb1.Items.Add(path);
                }
            }
            showFile();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void showFile()
        {
            try
            {
                listView.Clear();
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                listView.Columns.Add("Name", 230, 0);
                listView.Columns.Add("Size", 120, 0);
                listView.Columns.Add("Date", 160, 0);
                listView.View = View.Details;
                ListViewItem item;
                foreach (FileInfo d in directoryInfo.GetFiles("*"))
                {
                    item = new ListViewItem(d.Name);
                    item.SubItems.Add(d.Length.ToString());
                    item.SubItems.Add(d.CreationTime.ToLongDateString());
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

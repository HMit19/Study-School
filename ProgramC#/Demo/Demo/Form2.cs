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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text file(*.txt)|*.txt |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
            saveFile.InitialDirectory = "D:";
            saveFile.FileName = "FileName";
            saveFile.Title = "Chọn vị trí lưu file";
            //saveFile.AddExtension = true;
            //saveFile.DefaultExt = ".";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFile.FileName); // save tai vi tri file name
                try
                {
                    file.Write(txt.Text);
                    MessageBox.Show("Succesfull");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("faill");
                }
            }
        }
    }
}

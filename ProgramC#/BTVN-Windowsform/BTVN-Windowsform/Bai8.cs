using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Windowsform
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void clbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            clbFood.MultiColumn = true;
            clbFood.ColumnWidth = clbFood.Width / 2;
            clbFood.Items.Add("Ba chỉ cuốn nắm");
            clbFood.Items.Add("Ba chỉ luộc chấm mắm tép");
            clbFood.Items.Add("Thịt gà rang muối");
            clbFood.Items.Add("Thịt gà nướng");
            clbFood.Items.Add("Bê nướng");
            clbFood.Items.Add("Chả cá lã vọng");
            clbFood.Items.Add("Bún ốc");
            clbFood.Items.Add("Cháo chim bồ câu");
            clbFood.Items.Add("Cháo sườn");
            clbFood.Items.Add("Đậu rán");
            clbFood.Items.Add("Rau muống xào tỏi");
            clbFood.Items.Add("Rau bí ngô luộc");
        }

        private void clbFood_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Bạn vừa chọn thêm món: " + clbFood.SelectedItem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

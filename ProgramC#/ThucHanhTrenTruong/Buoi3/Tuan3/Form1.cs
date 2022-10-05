using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3
{
    public partial class Form1 : Form
    {
        string b1 = "Đau buồn chẳng phải khi người bỏ anh đi \n"
+ "Vì khi yêu thương phôi phai anh biết \n"
+ "Làm gì? Chuyện đến sẽ đến chẳng như ta vẫn nghĩ \n"
+ "Người kết thúc vội những phút giây ngủ mê. \n"
+ "Đau buồn chẳng phải khi người quên tên anh \n"
+ "Thời gian qua nhanh mang theo ký ức ngày nào \n"
+ "Cuộc sống tiếp diễn đưa em đến người khác \n"
+ "Rồi chẳng mấy khi nhớ lại một người đã đi qua. \n"
+ "\n[ĐK:] \n"
+ "Nhưng anh đau khi anh đánh mất em \n"
+ "Làm sao anh quên đi năm tháng ấy \n"
+ "Từng hoài niệm đó anh ghi vào tim \n"
+ "Từng ấm áp ấy anh giữ lại mãi \n"
+ "Cho vơi chua cay khi anh cô đơn. \n"
+ "Nhưng anh đau khi em dứt cánh tay \n"
+ "Rồi quay lưng đi khi anh cố níu \n"
+ "Tìm hình dáng ấy trong đêm mù tối \n"
+ "Tìm tiếng nói ấy sau những màn mưa \n"
+ "Ai xua tan đi giây phút có em qua rồi. \n"
+ "\n2. Ngước nhìn lên trời cao rồi hỏi trăng sao \n"
+ "Tình yêu nơi nao không mang những tiếng thở dài \n"
+ "Hạnh phúc quá ngắn khi ta sớm lìa nhau \n"
+ "Đành dấu chôn đi nỗi buồn chờ ngày hình dung phai. ";
        string b2 =
"Em mệt rồi anh ơi, nước mắt em đã rơi nhiều rồi \n"
+ "Em mệt rồi anh ơi, anh nói gì cũng chỉ thế thôi \n"
+ "Ngày mình chia tay, chỉ như thế rồi em lẳng lặng bước đi \n"
+ "Ngày mình chia tay, từng kí ức bủa vây anh trên đường về \n"
+ " \n"
+ "Tim anh bao bộn bề, mưa ơi đừng buồn thế … \n"
+ "Để cất em vào trong, rồi ban mai anh sẽ chẳng đợi mong \n"
+ "Là từng ấm êm khi ta còn nhau, là sẽ mãi bên nhau tới khi tóc phai màu \n"
+ "Là chờ ngày mai tới, trên lối về liệu còn thấy nhau \n"
+ "Anh biết tựa vào ai khi gió rét về đông, biết nói cùng ai bao nhớ thương trong lòng \n"
+ "Biết phải về đâu, bên anh giờ chỉ có hạt mưa ngâu … \n"
+ " \n"
+ "Rồi từng ngày vẫn trôi anh vẫn cứ vậy thôi \n"
+ "Một mình góc quán quen dẫu không em cạnh bên \n"
+ "Tự hỏi rằng nơi ấy, em đã tìm được người đón người đưa? \n"
+ "Một người thay thế anh, che chở em \n"
+ "Một người ôm lấy em, bên em đêm từng đêm \n"
+ "Một người khác thay anh \n"
+ "Yêu thương em tốt hơn anh! \n"
+ " \n"
+ "Tim anh bao bộn bề, mưa ơi đừng buồn thế … \n"
+ "Để cất em vào trong, rồi ban mai anh sẽ không đợi mong \n"
+ "Là từng ấm êm khi ta còn nhau, là sẽ mãi bên nhau tới khi tóc phai màu \n"
+ "Là chờ ngày mai tới, trên lối về liệu còn thấy nhau \n"
+ "Anh biết tựa vào ai khi gió rét về đông, biết nói cùng ai bao nhớ thương trong lòng \n"
+ "Biết phải về đâu, bên anh giờ chỉ có hạt mưa ngâu … \n"
+ " \n"
+ "Rồi từng ngày vẫn trôi anh vẫn cứ vậy thôi \n"
+ "Một mình góc quán quen dẫu không em cạnh bên \n"
+ "Tự hỏi rằng nơi ấy, em đã tìm được người đón người đưa? \n"
+ "Một người thay thế anh, che chở em \n"
+ "Một người ôm lấy em, bên em đêm từng đêm \n"
+ "Một người khác thay anh \n"
+ "Yêu thương em tốt hơn anh! \n"
+ " \n"
+ "Một người thay thế anh, che chở em \n"
+ "Một người ôm lấy em, bên em đêm từng đêm \n"
+ "Một người khác thay anh \n"
+ "Yêu thương em nhiều hơn anh!";
        Dictionary<string, string> data = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            data.Add("khiphaiquendi.mp3", b1);
            data.Add("muaoiduongbuon.mp3", b2);
        }

        private void cbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(cbODia.Text);
            DirectoryInfo[] directories = directory.GetDirectories("*.*");
            foreach (DirectoryInfo d in directories)
            {
                cbThuMuc.Items.Add(d);
            }
        }

        private void cbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBox.Items.Clear();
            lBox.Text = "";
            String[] files = Directory.GetFiles(cbODia.Text + cbThuMuc.Text);
            foreach (String f in files)
            {
                lBox.Items.Add(f);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                cbODia.Items.Add(d);
            }
        }

        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                FileStream file = new FileStream(lBox.Text, FileMode.Open);
                StreamReader rd = new StreamReader(file, Encoding.UTF8);
                string giatri = rd.ReadToEnd();
                rBox.Text = giatri;
                axMedia.URL = lBox.Text;
                int index = lBox.Text.LastIndexOf('\\');
                foreach (string t in data.Keys)
                {
                    if (t.Equals(lBox.Text.Substring(index + 1)))
                    {
                        rBox.Text = data[t];
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bài hát đang được phát!", "Cảnh báo");
            }
        }
    }
}
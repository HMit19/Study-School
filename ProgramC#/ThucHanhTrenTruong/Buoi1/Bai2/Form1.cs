namespace Bai2
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

        private double getHSG(double xA, double xB, double yA, double yB)
        {
            double hSG = 0;
            xA = Convert.ToDouble(txtXa.Text);
            yA = Convert.ToDouble(txtYa.Text);
            xB = Convert.ToDouble(txtXb.Text);
            yB = Convert.ToDouble(txtYb.Text);
            hSG = (yB - yA) / (xB - xA);
            return Math.Round(hSG, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xA = Convert.ToDouble(txtXa.Text);
            double yA = Convert.ToDouble(txtYa.Text);
            double xB = Convert.ToDouble(txtXb.Text);
            double yB = Convert.ToDouble(txtYb.Text);
            res1.Text = getHSG(xA, xB, yA, yB).ToString();
            res2.Text = getKC(xA, xB, yA, yB).ToString();
        }

        private double getKC(double xA, double xB, double yA, double yB)
        {
            double KC = 0;
            KC = Math.Sqrt((xB - xA) * (yB - yA) + (xB - xA) * (xB - xA));
            return Math.Round(KC, 2);
        }
    }
}
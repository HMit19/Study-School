namespace MyApp;

public class sukien
{
    public delegate void sukiennhapso(int x);
    /*
     publisher de phat su kien
     subscribe de nhan su kien
     */

    class nhapdulieu:EventArgs
    {
        public int data { set; get; }
        public nhapdulieu(int x) => this.data = x;
    }

    // publisher
    class UserInput
    {
        // public sukiennhapso sukiennhap { set; get; }

        public event sukiennhapso sukiennhap;
        // public EventHandler sukiennhap; // tuong duong voi event sukiennhapso sukiennhap; ~ delegate void sukiennhapso(Object? sender, EventArgs e);

        public void input()
        {
            Console.WriteLine("Nhap 1 con so: ");
            int s = Convert.ToInt32(Console.ReadLine());
            // phat di su kien
            sukiennhap?.Invoke();
        }
    }

    class TinhCan
    {
        // dang ky su kien
        public void Sub(UserInput input)
        {
            input.sukiennhap += Can;
        }

        // xu ly su kien
        public void Can(Object? sender, EventArgs e)
        {
            nhapdulieu data = e as nhapdulieu;
            Console.WriteLine("Can cua {0} la {1}", data.data, Math.Sqrt(data.data));
        }
    }

    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            // gan sukiennhap = phuong thuc binh
            input.sukiennhap += Binh;
        }

        private void Binh(object sender, EventArgs e)
        {
            nhapdulieu data = e as nhapdulieu;
            Console.WriteLine($"Binh phuong cua {data.data} la {Math.Pow(data.data, 2)}");
        }
    }

    static void Main(string[] args)
    {
        // publisher
        UserInput ui = new UserInput();
        TinhCan tinhCan = new TinhCan();
        ui.sukiennhap += (sender, e) =>
        {
            int a = ((nhapdulieu)e).data;
            Console.WriteLine($"Su kien nhap {a}");
        };
        tinhCan.Sub(ui);
        BinhPhuong bac = new BinhPhuong();
        bac.Sub(ui);
        ui.input();
    }
}
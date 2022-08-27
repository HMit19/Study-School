using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class Sach
    {
        protected string id;
        protected string name;
        protected string author;
        protected int quantity;

        public Sach()
        {
        }

        public Sach(string id, string name, string author, int quantity)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.quantity = quantity;
        }
        public void inputSach()
        {
            Console.Write("\nEnter id book: ");
            id = Console.ReadLine();
            Console.Write("Enter name book: ");
            name = Console.ReadLine();
            Console.Write("Enter author book: ");
            author = Console.ReadLine();
            Console.Write("Enter quantity book: ");
            quantity = int.Parse(Console.ReadLine());

        }
    }

    public class SachPlus : Sach
    {
        private int qrCode;
        List<SachPlus> listbook;

        public int QrCode { get => qrCode; set => qrCode = value; }

        public SachPlus()
        {
        }

        public SachPlus(string id, string name, string author, int quantity, int qrCode) : base(id, name, author, quantity)
        {
            this.QrCode = qrCode;
        }
        public void intputSach()
        {
            Console.Write("Enter quantity book: ");
            int number = int.Parse(Console.ReadLine());
            listbook = new List<SachPlus>(number);
            for (int i = 0; i < number; i++)
            {
                SachPlus book = new SachPlus();
                book.inputSach();
                Console.Write("Enter QR code: ");
                book.QrCode = int.Parse(Console.ReadLine());
                listbook.Add(book);
            }
        }

        public int checkQRCode(int qr)
        {
            int count = 0;
            foreach (SachPlus book in listbook)
            {
                if (book.QrCode == qr)
                {
                    count += book.quantity;
                }
            }
            return count;
        }
    }
}

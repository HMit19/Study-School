using in_out;

// Console là 1 lớp của System namespace chứa các phương thức để nhập(Console.Readline()), xuất(Console.WriteLine()|Console.Write()).
// sizeof(type): return kích thước của kiểu type
// a is type: kiểu tra biến a có thuộc kiểu type
// typeof(type): trả về kiểu của type thường kết hợp với GetType() để check kiểu dữ liệu
// as: ép kiểu không trả về exception
// $"...{variable type string}...": show string and variable type string
// không thể ép kiểu string, chỉ có chuyển kiểu
// Sử dụng đối tượng Math để sử dụng các hàm toán học
// sử dụng đối tượng Array để thao tác trên mảng
// namespace System.Linq chứa các phương thức lấy giá trị max min trong object
// trong Console.Writeln có 2 cách để xuất dữ liệu biến
//1, EL Console.Writeln($"{variable}");
//2, Index Console.Writeln("{index}{index2}{indexn}", index1, index2...indexn);
// kiểu nullable có thể chứa giá trị của nó hoặc là null VD: string
// toán tử ?? dùng để trả về biến có giá trị khác null
// enum là một lớp đại diện cho nhóm các hằng số, dùng nhiều trong switch case, dùng khi các giá trị không đổi
// mỗi giá trị sẽ có một index cụ thể vd level.medium thì có index = 2
// e.StackTrace và e.Message: để hiển thị lỗi.
// ta có thể tự định nghĩa được exception

namespace in_out

{
    class myException : Exception
    {
        public myException(string message) : base(message)
        {
        }
    }

    class Scanner
    {
        public int nhap(int a)
        {
            Console.WriteLine("Nhap vao 1 so nguyen: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                throw (new myException("sai roi"));
            return a;
        }

        public void xuat(int x)
        {
            Console.WriteLine("thong tin can xuat ra man hinh: ");
            Console.WriteLine(x);
        }
    }
}

namespace TheFirstProgram
{
    class Program
    {
        public static void nhap(string id)
        {
            Console.WriteLine("Nhap id: ");
            int i = Convert.ToInt32(Console.ReadLine());
        }

        public static void xuat(string id)
        {
            Console.WriteLine("id = ${0}", id);
        }
        public delegate void input(string input);
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 0;
            //    Scanner scanner = new Scanner();
            //    a = scanner.nhap(a);
            //    scanner.xuat(a);
            //}
            //catch (myException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.WriteLine("Hello World!");
            input inp;
            inp = nhap;
            inp("oke");
        }
    }
}
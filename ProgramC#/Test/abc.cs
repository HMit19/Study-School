using System;
using System.Linq;
namespace abc
{
    interface xe
    {
        void show();
        void showchitiet();
    }
    class xemay : xe
    {
        int tocdo;
        int width, height;
        public xemay(int tocdo, int width, int height)
        {
            this.tocdo = tocdo;
            this.width = width;
            this.height = height;
        }
        public void show()
        {
            Console.WriteLine("Toc do cua xe la: {0}", this.tocdo);
        }
        public void showchitiet()
        {
            Console.WriteLine("Width: {0}\nHeight: {1}", this.width, this.height);
        }
    }
}




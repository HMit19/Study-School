using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class SachNew : Sach
    {
        private string qrCode;

        public SachNew()
        {
        }
        public SachNew(string id, string name, string author, int quantity, string qrCode) : base(id, name, author, quantity)
        {
            this.qrCode = qrCode;
        }
    }

}

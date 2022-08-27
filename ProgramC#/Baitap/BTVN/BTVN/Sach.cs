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

        public Sach() { }

        public Sach(string id, string name, string author, int quantity)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.quantity = quantity;
        }
    }
}

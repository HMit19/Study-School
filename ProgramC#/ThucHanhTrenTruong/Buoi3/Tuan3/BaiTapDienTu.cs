using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;
        public BaiTapDienTu() { }

        public BaiTapDienTu(BaiTapDienTu baiTap) {
            this.debai = baiTap.debai;
            this.dapan = baiTap.dapan;
            this.dapantungcau = baiTap.dapantungcau;
        }
        public string Debai { get => debai; set => debai = value; }
        public string Dapan { get => dapan; set => dapan = value; }
        public List<string> Dapantungcau { get => dapantungcau; set => dapantungcau = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class LopHoc
    {
        private string TenLop;
        public int SiSo;
        public LopHoc()
        {
        }
        public LopHoc(string tenLop, int siSo)
        {
            TenLop = tenLop;
            SiSo = siSo;
        }
        private void TTLop()
        {
            Console.WriteLine("Nhap thong tin lop hoc:");
            Console.Write("Ten lop: ");
            TenLop = Console.ReadLine();
            Console.Write("Si so: ");
            SiSo = int.Parse(Console.ReadLine());
            Hocsinh.DanhSachHS dshs=new Hocsinh.DanhSachHS();
            dshs.NhapDS();
            dshs.HienThiDS();
            dshs.MaxDTB();
        }
        public class lopHoc
        {
            public lopHoc()
            {
                LopHoc LH= new LopHoc();
                LH.TTLop();
                Hocsinh.DanhSachTL ds=new Hocsinh.DanhSachTL();

            }
        }
    }
}

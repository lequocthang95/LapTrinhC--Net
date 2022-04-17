using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class HinhChuNhat
    {
        public float ChieuDai;
        public float ChieuRong;
       
        public HinhChuNhat(float cd, float cr)
        {
            ChieuDai = cd;
            ChieuRong = cr;
        }
        public HinhChuNhat()
        {

        }
        public void NhapKT()
        {
            Console.WriteLine("Nhap kich thuoc hinh chu nhat: ");
            Console.Write("Chieu dai: ");
            ChieuDai = float.Parse(Console.ReadLine());
            Console.Write("Chieu rong: ");
            ChieuRong  = float.Parse(Console.ReadLine());
        }
        private double ChuVi()
        {
            return 2*(ChieuDai +ChieuRong);
        }
        private double DienTich()
        {
            return (ChieuDai*ChieuRong);
        }
        public void HienThiTT()
        {
            Console.WriteLine($"Hinh chu nhat: chieu dai={ChieuDai}, chieu rong={ChieuRong}, " +
                $"chu vi={ChuVi()}, dien tich={DienTich()}");
        }
        public class hinhChuNhat
        {
            public hinhChuNhat()
            {
                HinhChuNhat hcn = new HinhChuNhat();
                hcn.NhapKT();
                hcn.HienThiTT();
            }
        }
    }
}

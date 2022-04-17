using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class KhachSan
    {
        private string SoPhong;
        private string LoaiPhong;
        private int SoNgayThue;
        private void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin phong: ");
            Console.Write("So phong: ");
            SoPhong = Console.ReadLine();
            Console.Write("Loai phong: ");
            LoaiPhong = Console.ReadLine();
            Console.Write("So ngay thue:");
            SoNgayThue = int.Parse(Console.ReadLine());
        }
        private int GiaThue()
        {
            switch (LoaiPhong)
            {
                case "A":
                    return 500000;
                case "B":
                    return 350000;
                case "C":
                    return 200000;
                default:
                    Console.WriteLine("vui long nhap dung loai phong(loai phong viet hoa)");
                    return 0;
            }
        }
        private void InHoaDon()
        {
            Console.WriteLine("Thong tin phong: ");
            Console.WriteLine($"So phong: {SoPhong}, loai phong: {LoaiPhong}, gia thue phong: {GiaThue()}d/ngay," +
                $"thoi gian thue: {SoNgayThue} ngay, so tien can thanh toan la: {GiaThue() * SoNgayThue}d");
            Console.WriteLine("Cam on quy khach!");
        }
        public class khachSan
        {
            public khachSan()
            {
                KhachSan ks = new KhachSan();
                ks.NhapThongTin();
                ks.InHoaDon();
            }
        }
    }
}

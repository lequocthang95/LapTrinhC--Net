using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class Nhanvien
    {
        private string MS;
        private string HT;
        private string GT;
        private string DC;
        private double HSL;
        private double PhuCap;
        private Nhanvien(string ms, string ht, string gt, string dc, double hsLuong, double pc)
        {   
            MS = ms;
            this.HT = ht;
            GT = gt;
            DC = dc;
            HSL = hsLuong;
            PhuCap = pc;
        }
        private Nhanvien()
        {
            HSL = 2.5;
            PhuCap = 250000;
        }
        private void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin nhan vien:");
            Console.Write("Ma so nhan vien: ");
            MS  = Console.ReadLine();
            Console.Write("Ten nhan vien: ");
            HT = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            GT = Console.ReadLine();
        }
        private double luong()
        {
            return HSL * 1210000 + PhuCap;
        }
        private void HienThi()
        {
            Console.WriteLine("Thong tin nhan vien: ");
            Console.WriteLine($"Ma so: {MS}, Ho ten: {HT}, Gioi tinh: {GT}, Dia chi: {DC}");
            Console.WriteLine($"Luong cua nhan vien nay la: {luong()}");
        }
        public class TTNhanVien
        {   
            public TTNhanVien()
            {
                Nhanvien nv = new Nhanvien();
                nv.NhapThongTin();
                nv.HienThi();
            }
        }
    }
}

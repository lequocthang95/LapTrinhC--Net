using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class Hocsinh
    {
        private string MSHS;
        private string HoTen;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private double DiemHK1;
        private double DiemHK2;
        private float DiemToan, DiemLy, DiemHoa;
        static int demHS;
        static ConsoleKeyInfo k;
        static Hocsinh[] dsHocSinh;
        private Hocsinh(string ms, string ht, string gt,string dc, string sdt, double hk1, double hk2, float diemToan, float diemLy, float diemHoa)
        {
            MSHS = ms;
            HoTen = ht;
            GioiTinh = gt;
            DiaChi = dc;
            SDT = sdt;
            DiemHK1 = hk1;
            DiemHK2 = hk2;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            
        }
        private Hocsinh()
        {

        }
        private void NhapTT()
        {
            Console.WriteLine($"Nhap thong tin hoc sinh: ");
            Console.Write("Ten HS: ");
            HoTen = Console.ReadLine();
            /*Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("So dien thoai: ");
            SDT = Console.ReadLine();*/
            Console.Write("Diem hoc ki 1: ");
            DiemHK1 = double.Parse(Console.ReadLine());
            Console.Write("Diem hoc ki 2: ");
            DiemHK2 = double.Parse(Console.ReadLine());
            /*Console.Write("Diem Toan: ");
            DiemToan = float.Parse(Console.ReadLine());
            Console.Write("Diem Ly: ");
            DiemLy = float.Parse(Console.ReadLine());
            Console.Write("Diem Hoa: ");
            DiemHoa = float.Parse(Console.ReadLine());*/
            demHS++;
            MSHS = demHS.ToString();
            k = Console.ReadKey();
        }
        private void showHS()
        {
            Console.WriteLine($"Ma so: {MSHS}, Ho ten: {HoTen}, diem Toan: {DiemToan}, diem Ly: {DiemLy}, " +
                $"diem Hoa: {DiemHoa}, diem Hk1: {DiemHK1}, diem HK2: {DiemHK2}, diem TB: {DiemTB()}, xep loai: {xeploai()}");
        }
        public bool ThiLai()
        {
            return (DiemHoa<5||DiemLy<5||DiemToan<5);
        }
        private double DiemTB()
        {
            return ((DiemHK1 + DiemHK2) / 2);
        }
        private string xeploai()
        {
            if (DiemTB() < 5)
            {
                return "Hoc luc yeu";
            }
            else if (DiemTB() < 7)
            {
                return "Hoc luc trung binh";
            }
            else if (DiemTB() < 8)
            {
                return "Hoc luc kha";
            }

            else if (DiemTB() < 9)
            {
                return "Hoc Luc gioi";
            }
            else if (DiemTB() < 10)
            {
                return "Hoc luc xuat sac";
            }
            else return "Thong tin diem khong chinh xac";
        }
        public class DanhSachHS
        {
            protected LopHoc lophoc = new LopHoc();
            public void NhapDS()
            {
                dsHocSinh = new Hocsinh[50];
                do
                {
                    k = Console.ReadKey();
                    Hocsinh hsinh = new Hocsinh();
                    hsinh.NhapTT();
                    dsHocSinh[demHS - 1] = hsinh;
                }
                while (k.Key != ConsoleKey.Escape);
            }
            public void HienThiDS()
            {
                Console.WriteLine("Danh sach hoc sinh: ");
                for (int i = 0; i < demHS; i++)
                    dsHocSinh[i].showHS();
            }
            public void SortDTBGiam()
            {
                for (int i = 0; i < demHS - 1; i++)
                {
                    for (int j = i+1; j < demHS; j++)
                    {
                        if (dsHocSinh[i].DiemTB() < dsHocSinh[j].DiemTB())
                        {
                            Hocsinh tam = dsHocSinh[i];
                            dsHocSinh[i] = dsHocSinh[j];
                            dsHocSinh[j] = tam;
                        }
                    }
                }
            }
            public void MaxDTB()
            {
                Hocsinh maxHS = new Hocsinh();
                maxHS = dsHocSinh[0];
                for (int i = 1; i < demHS; i++)
                {
                    if (maxHS.DiemTB() < dsHocSinh[i].DiemTB())
                    {
                        maxHS = dsHocSinh[i];
                    }
                }
                Console.WriteLine($"Hoc sinh co diem TB cao nhat la: {maxHS.HoTen}");
            }
        }
        public class DanhSachTL
        {
            private Hocsinh[] dsThiLai;
            private int dem;
            public void TaoDSTL()
            {
                dsThiLai = new Hocsinh[50];
                dem = 0;
                for (int i = 0; i < demHS; i++)
                {
                    if (dsHocSinh[i].ThiLai() == true)
                    {
                        dsThiLai[i] = dsHocSinh[i];
                        dem++;
                    }
                }
                                      
            }
            public void HienThiDSTH()
            {
                Console.WriteLine(dem);
                if (dem > 0)
                {
                    Console.WriteLine("Danh sach hoc sinh thi lai: ");
                    for (int i = 0; i < dem; i++)                        
                        dsThiLai[i].showHS();
                }
                else
                    Console.WriteLine("Khong co hoc sinh nao phai thi lai.");
            }
        }
        public class hocSinh
        {   
            public hocSinh()
            {
                DanhSachHS dsach = new DanhSachHS();
                dsach.NhapDS();
                dsach.MaxDTB();
                dsach.SortDTBGiam();
                dsach.HienThiDS();

                /*DanhSachTL dsachTL = new DanhSachTL();
                dsachTL.TaoDSTL();
                dsachTL.HienThiDSTH();*/
            }
        }
    }
}

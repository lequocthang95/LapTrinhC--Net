using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TenCT;
            Console.Write("Nhap ten chuong trinh ma ban muon chay: ");
            TenCT = Console.ReadLine();
            switch (TenCT)
            {
                case "toa do":
                    ToaDo.Diem2D diem2D = new ToaDo.Diem2D();
                    break;
                case "stack":
                    Stack.stack stc = new Stack.stack();
                    break;
                case "pt bac 1":
                    PtBac1.tinhNghiem tinhNghiem = new PtBac1.tinhNghiem();
                    break;
                case "hoc sinh":
                    Hocsinh.hocSinh hocsinh = new Hocsinh.hocSinh();
                    break;
                case "lop hoc":
                    LopHoc.lopHoc lopHoc = new LopHoc.lopHoc();
                    break;
                case "nhan vien":
                    Nhanvien.TTNhanVien nhanvien = new Nhanvien.TTNhanVien();
                    break;
                case "khach san":
                    KhachSan.khachSan khachsan = new KhachSan.khachSan();
                    break;
                case "hinh hoc":
                    HinhHoc hHoc = new HinhHoc();
                    break;
                case "in ten": /*Bài 1:*/
                    Console.Write("Nhap ten cua ban: ");
                    string tenban = Console.ReadLine();
                    Console.WriteLine($"Chao {tenban}");
                    for (int i = 0; i < tenban.Length + 12; i++)   /*Bai 2*/
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"*     {tenban}     *");
                    for (int i = 0; i < tenban.Length + 12; i++)
                    {
                        Console.Write("*");
                    }
                    break;
                case "nam sinh":/*Bai 3*/
                    Console.WriteLine("Nhap ngay thang nam: ");
                    Console.Write("ngay: ");
                    int ngay = int.Parse(Console.ReadLine());
                    Console.Write("thang: ");
                    int thang = int.Parse(Console.ReadLine());
                    Console.Write("nam: ");
                    int nam = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{ngay}/{thang}/{nam}");
                    break;
                case "phep toan":
                    Console.Write($"Nhap so a = ");
                    float a = float.Parse(Console.ReadLine());
                    Console.Write($"Nhap so b = ");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"phan thuong cua a/b la : {a / b}");/*Bai 4*/
                    Console.WriteLine($"phan du cua a/b la : {a % b}");
                    Console.WriteLine($"a+b = {a + b}"); /*Bai 5*/
                    Console.WriteLine($"a-b = {a - b}");
                    Console.WriteLine($"a*b = {a * b}");
                    Console.WriteLine($"a/b = {a / b}");
                    break;
                default: 
                    Console.WriteLine("Vui long nhap chinh xac ten chuong trinh ban muon chay");
                    break;
            }                                             
            /*Bai 6*/
            /*Console.Write($"Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"gia tri a sau khi hoan doi la a = {a}");
            Console.WriteLine($"gia tri a sau khi hoan doi la b = {b}");*/

            /*Bai 7*/
            /*Console.Write($"Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so d = ");
            int d = int.Parse(Console.ReadLine());
            float tong = a + b + c + d;
            float tbc = tong / 4;
            Console.WriteLine($"gia tri trung binh cong cua 4 so a,b,c,d la: {tbc}");*/

            /*Bai 8*/

            /*ConsoleKeyInfo k;
            
            Console.WriteLine("Bat dau chuong trinh doi cac don vi do, nhan phim \"esc\" neu ban muon dung chuong trinh");
            Console.WriteLine("Hay cho biet ban muon doi don vi nao?(phim\"a\" doi do C, phim \"b\" doi Hai Ly, phim \"c\" doi Pound, phim \"d\" doi Mile )");
            do
            {
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.A: 
                        Console.Write("\tNhap vao do C : ");
                        float do_C = float.Parse(Console.ReadLine());
                        double do_F = 9 * do_C / 5 + 32;
                        Console.WriteLine($"{do_C} do C = {do_F}");
                    break;
                    case ConsoleKey.B:
                        Console.Write("\tNhap vao so Hai ly : ");
                        float haily = float.Parse(Console.ReadLine());
                        double km = 1.852 * haily;
                        Console.WriteLine($"{haily} Hai ly = {km} km");
                    break;
                    case ConsoleKey.C:
                        Console.Write("\tNhap vao so Pound : ");
                        float pound = float.Parse(Console.ReadLine());
                        double kg = 0.454 * pound;
                        Console.WriteLine($"{pound} Pound = {kg} Kg");
                        break;
                    case ConsoleKey.D:
                        Console.Write("\tNhap vao so Mile: ");
                        float mile = float.Parse(Console.ReadLine());
                        double km2 = 1.609 * mile;
                        Console.WriteLine($"{mile} Mile = {km2} Km");
                        break;
                    default: Console.WriteLine("vui long nhap dung phim de bat dau");break;
                }
            } while (k.Key != ConsoleKey.Escape);

            /*Bai 9*/
            /*Console.Write($"Nhap gia tri dien tro R1 = ");
            float r1 = float.Parse(Console.ReadLine());
            Console.Write($"Nhap gia tri dien tro R2 = ");
            float r2 = float.Parse(Console.ReadLine());
            Console.Write($"Nhap gia tri dien tro R3 = ");
            float r3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Tong dien tro la : R = {1/(1/r1+1/r2+1/r3)}");*/

            /*Bai 10*/
            /*Console.Write($"Nhap do dai canh a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write($"Nhap do dai canh b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write($"Nhap do dai canh c = ");
            float c = float.Parse(Console.ReadLine());
            float p = (a+b+c)/2;
            bool check = true;
            if (a+b<=c || a+c<=b || b+c<=a)
            {
                check = false;
            }
            if (check == true)
            {
                Console.WriteLine($"Chu vi cua tam giac la: {p * 2}");
                Console.WriteLine($"Dien tich cua tam giac la {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
            }
            else
            {
                Console.WriteLine("Ba canh nay khong the tao nen tam giac");
            }*/


            /*Bai 11*/
            /*Console.Write($"Nhap can nang: cannang = ");
            float cannang = float.Parse(Console.ReadLine());
            Console.Write($"Nhap chieu cao: chieucao = ");
            float chieucao = float.Parse(Console.ReadLine());
            double bmi = cannang/Math.Pow(chieucao,2);
            Console.WriteLine(bmi);
            if (bmi < 18)
            {
                Console.WriteLine("nguoi gay");
            }
            else
            {
                if (bmi >= 35) Console.WriteLine("nguoi beo phi do III");
                else
                {
                    if (bmi < 25) Console.WriteLine("nguoi binh thuong");
                    else
                    {
                        if (bmi < 30) Console.WriteLine("nguoi beo phi do I");
                        else Console.WriteLine("nguoi beo phi do II");
                    }
                        
                }
            }*/

            /*Bai 12*/
            /*Console.Write($"Nhap so a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write($"Nhap so b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write($"Nhap so c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write($"Nhap so d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write($"Nhap so e = ");
            double e = double.Parse(Console.ReadLine());
            double max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            Console.Write($"So lon nhat trong 5 so la {max}");*/

            /*Bai 13*/
            /*Console.Write($"Nhap vao nam: ");
            int nam = int.Parse(Console.ReadLine());
            if ((nam % 4 == 0) && (nam % 100 != 0))
            {
                Console.WriteLine($"Nam {nam} la nam nhuan");
            }
            else Console.WriteLine($"Nam {nam} khong phai la nam nhuan");*/

            /*Bai 14*/
            /*Console.Write($"Nhap vao mot so nguyen bat ky: n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }*/

            /*Bai 15*/
            /*Console.Write($"Nhap vao so KW tieu thu trong thang: dien = ");
            int dien = int.Parse(Console.ReadLine());
            int tien;
            if (dien <= 100)
            {
                tien = dien * 3000;
            }
            else
            {
                if (dien <= 150)
                {
                    tien = dien * 5000;
                }
                else tien = dien * 7000;
            }
            tien =tien + tien * 10 / 100;
            Console.WriteLine($"Tien dien tieu thu la {tien}d");*/

            /*Bai 16*/
            /*Console.Write($"Nhap vao so Km di duoc: km = ");
            float km = float.Parse(Console.ReadLine());
            float tien;
            tien = km * 15000;
            if (km > 31)
            {
                tien = 15000 + 11000 * km;
            }
            else
            {
                if (km > 1)
                {
                    tien = 15000 + km * 12000;
                }
                else
                {
                    if (km <= 0)
                    {
                        Console.WriteLine("So km phai lon hon 0");
                    }
                }
            }
            Console.WriteLine($"Tien taxi phai thanh toan la {tien} d");*/

            /*Bai 17*/
            /*Console.WriteLine("Nhap diem 3 mon:");
            Console.Write("Diem Toan: ");
            float toan = float.Parse(Console.ReadLine());
            Console.Write("Diem Tin hoc: ");
            float th = float.Parse(Console.ReadLine());
            Console.Write("Diem Ngoai ngu: ");
            float nn = float.Parse(Console.ReadLine());
            float tb = (toan + th + nn) / 3;
            Console.WriteLine($"Diem trung binh 3 mon la: {tb}");
            if (tb < 5)
            {
                Console.WriteLine("xep loai kem");
            }
            else
            {
                if (tb<6) Console.WriteLine("xep loai trung binh");
                else
                {
                    if (tb < 7) Console.WriteLine("xep loai TB kha");
                    else
                    {
                        if (tb < 8)
                        {
                            if (toan < 7 || nn < 7 || th < 7) Console.WriteLine("xep loai TB kha");
                            else Console.WriteLine("xep loai kha");
                        }
                        else
                        {
                            if (toan < 8 || nn < 8 || th < 8) Console.WriteLine("xep loai kha");
                            else Console.WriteLine("xep loai gioi");
                        }

                    }
                }
            }*/

            /*Bai 18*/
            /*Console.Write($"Nhap vao nam sinh: nam = ");
            int nam = int.Parse(Console.ReadLine());
            int checkCan = (nam + 6) % 10;
            int checkChi = (nam + 8) % 12;
            string can = "";
            string chi = "";
            switch (checkCan)
            {
                case 0: can = "Giap";break;
                case 1: can = "At";break;
                case 2: can = "Binh"; break;
                case 3: can = "Dinh"; break;
                case 4: can = "Mau"; break;
                case 5: can = "Ky"; break;
                case 6: can = "Canh"; break;
                case 7: can = "Tan"; break;
                case 8: can = "Nham"; break;
                case 9: can = "Quy"; break;
            }
            switch (checkChi)
            {
                case 0: chi = "Ty"; break;
                case 1: chi = "Suu"; break;
                case 2: chi = "Dan"; break;
                case 3: chi = "Meo"; break;
                case 4: chi = "Thin"; break;
                case 5: chi = "Ty"; break;
                case 6: chi = "Ngo"; break;
                case 7: chi = "Mui"; break;
                case 8: chi = "Than"; break;
                case 9: chi = "Dau"; break;
                case 10: chi = "Tuat"; break;
                case 11: chi = "Hoi"; break;
            }
            Console.WriteLine($"Nam {nam} la nam {can} {chi}");*/

            /*Bai 19*/
            /*Console.Write($"Nhap vao mot so nguyen bat ky: n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
               Console.WriteLine(i);
            }
            */

            /*Bai 20*/
            /*Console.Write($"Nhap vao mot so nguyen bat ky: a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Nhap vao mot so nguyen bat ky: n = ");
            int n = int.Parse(Console.ReadLine());
            double nPow = Math.Pow(a, n);
            Console.Write($"{a}^{n} = {nPow}");*/

            /*Bai 21*/
            /*Console.Write($"Nhap vao mot so tien vay ban dau: tienvay = ");
            int tienvay = int.Parse(Console.ReadLine());
            Console.Write($"Nhap vao so thang vay: thoigian = ");
            int thoigian = int.Parse(Console.ReadLine());
            Console.Write($"Nhap lai suat vay theo thang: laisuat = ");
            int laisuat = int.Parse(Console.ReadLine());
            int tongtien = tienvay + tienvay * laisuat * thoigian / 100;
            Console.WriteLine($"Tong so tien can phai tra la: {tongtien}d");*/

            /*Bai 22*/
            /*Console.Write($"Nhap vao gia xe ban dau: gia = ");
            int gia = int.Parse(Console.ReadLine());
            Console.Write($"Nhap vao so tien tra truoc: tratruoc = ");
            int tratruoc = int.Parse(Console.ReadLine());
            Console.Write($"Nhap vao so thang vay: thoigian = ");
            int thoigian = int.Parse(Console.ReadLine());
            Console.Write($"Nhap lai suat vay theo thang: laisuat = ");
            int laisuat = int.Parse(Console.ReadLine());
            int tongtien = tratruoc + (gia - tratruoc) * laisuat * thoigian / 100;
            Console.WriteLine($"So tien phai tra gop moi thang la: {(gia-tratruoc)*laisuat/100}d");
            Console.WriteLine($"Tong so tien can phai tra la: {tongtien}d");*/

            /*Bai 23*/
            /*int tongSp = 0;
            Console.Write($"Nhap luong cua 1 san pham: ");
            int luongSp = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Nhap so san pham cua ngay {i}: ");
                int sp = int.Parse(Console.ReadLine());
                tongSp = tongSp + sp;
            }
            Console.WriteLine($"Tong san pham lam duoc la {tongSp} san pham");
            Console.WriteLine($"Luong thang la: {tongSp * luongSp}");*/

            /*Bai 24*/
            /*double danso = 90000000;
            Console.Write($"Nhap mot so nguyen duong bat ky: n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                danso = danso + danso * 1.05 / 100;
            }
            Console.Write($"Dan so sau {n} nam nua la: {danso}");*/

            /*Bai 25*/
            /*double tien;
            do
            {
                Console.Write($"Nhap so tien gui ban dau < 1 ty dong: ");
                tien = long.Parse(Console.ReadLine());
            }
            while (tien >= 1000000000);
            int i = 0;
            do
            {
                tien = tien + tien * 0.0075;
                Console.WriteLine(tien);
                i++;
            }
            while (tien <= 1000000000   );
            Console.WriteLine($"Sau {i} thang thi nguoi do tro thanh ty phu");*/

            Console.ReadKey();                                   
        }
    }
}

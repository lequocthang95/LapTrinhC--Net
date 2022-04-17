using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class Tamgiac
    {
        private float a;
        private float b;
        private float c;
        public void Nhap()
        {
            Console.Write($"Nhap do dai canh a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write($"Nhap do dai canh b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write($"Nhap do dai canh c = ");
            c = float.Parse(Console.ReadLine());
        }
        private bool check()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }

            else
                return true;
        }
        private string loaiTG()
        {
            if (a == b || b== c || a==c)
            {
                if(a == b && b == c)
                {
                    return "tam giac deu";
                }
                else
                {
                    if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                    {
                        return "tam giac vuong can";
                    }
                    else return "tam giac can";
                }
            }
            else
            {
                if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                {
                    return "tam giac vuong";
                }
                else return "tam giac thuong";
            }
        }
        private double chuvi()
        {
            return (a + b + c);
        }
        private double dientich()
        {
            double p = chuvi()/2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        public class hienThi
        {
            public hienThi()
            {
                Tamgiac tg=new Tamgiac();
                tg.Nhap();
                if (tg.check() == false)
                {
                    Console.WriteLine("3 canh vua nhap khong phai la 3 canh cua tam giac");
                }
                else
                {
                    Console.WriteLine($"Tam giac co do dai 3 canh la: {tg.a},{tg.b},{tg.c}");
                    Console.WriteLine($"Tam giac nay la {tg.loaiTG()}");
                    Console.WriteLine($"Chu vi tam giac: {tg.chuvi()}");
                    Console.WriteLine($"Dien tich tam giac la: {tg.dientich()}");
                }
            }
        }
    }
}

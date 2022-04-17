using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class ToaDo
    {
        public int x;
        public int y;
        public void Nhap()
        {
            Console.Write("Nhap hoanh do: x=");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: y=");
            y = int.Parse(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.WriteLine($"({x},{y})");
        }
        public void DoiToaDo()
        {
            int x1 = -x;
            int y1 = -y;
            Console.WriteLine($"({x1},{y1})");
        }
        public void DiChuyen(int x1, int y1)
        {
            int x2 = x+x1;
            int y2 = y+y1;
            Console.WriteLine($"({x2},{y2})");
        }
        public double KhoangCach(ToaDo d)
        {   
            double t1 = Math.Pow(d.x-x,2);
            double t2 = Math.Pow(d.y-y,2);
            return Math.Sqrt(t1+t2); 
        }
        public class Diem2D
        {
            public Diem2D()
            {
                ToaDo d1 = new ToaDo();
                ToaDo d2 = new ToaDo();
                ToaDo d3 = new ToaDo();
                Console.WriteLine("Nhap toa do diem D1:");
                d1.Nhap();
                Console.WriteLine("Nhap toa do diem D2:");
                d2.Nhap();
                Console.WriteLine("Nhap toa do diem D3:");
                d3.Nhap();
                Console.WriteLine("Toa do cac diem la: ");
                Console.Write("d1");
                d1.HienThi();
                Console.Write("d2");
                d2.HienThi();
                Console.Write("d3");
                d3.HienThi();
                Console.WriteLine("Cac diem sau khi doi toa do");
                Console.Write("d1");
                d1.DoiToaDo();
                Console.Write("d2");
                d2.DoiToaDo();
                Console.Write("d3");
                d3.DoiToaDo();
                Console.WriteLine("Cac diem sau khi di chuyen:");
                Console.Write("d1");
                d1.DiChuyen(12, 12);
                Console.Write("d2");
                d2.DiChuyen(12, 12);
                Console.Write("d3");
                d3.DiChuyen(12, 12);
                Console.WriteLine("Khoang cach diem:");
                Console.WriteLine($"d1->d2: {d1.KhoangCach(d2)}");
                Console.WriteLine($"d1->d3: {d1.KhoangCach(d3)}");
                Console.WriteLine($"d2->d3: {d2.KhoangCach(d3)}");


            }
        }
    }
}

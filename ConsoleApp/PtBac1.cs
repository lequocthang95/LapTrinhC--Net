using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class PtBac1
    {
        private float a;
        private float b;
        private void nhap()
        {
            Console.Write("Nhap a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b=");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Phuong trinh can giai la: {a}x+{b}=0");
        }
        public class tinhNghiem
        {
            public tinhNghiem()
            {
                PtBac1 pt = new PtBac1();
                pt.nhap();
                if (pt.a == 0)
                {
                    Console.WriteLine("Pt vo nghiem");
                }
                else
                {
                    if (pt.b == 0)
                    {
                        Console.WriteLine("PT co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine($"pt co nghiem x={-pt.b / pt.a}");
                    }
                }
            }
        }
        
    }
}

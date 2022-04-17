using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class HinhTron
    {
        private float bankinh;
        private ToaDo diem = new ToaDo();
        public HinhTron()
        {
            Console.WriteLine("Nhap toa diem tam cua hinh tron: ");
            diem.Nhap();
            Console.Write("Nhap ban kinh hinh tron: ");
            bankinh = float.Parse(Console.ReadLine());
        }
        public double ChuViHinhTron()
        {
            return this.bankinh * 2 * 3.14;
        }
        public double DienTichHinhTron()
        {
            return (Math.PI * (this.bankinh * this.bankinh));
        }
        public void HienThiHinhTron()
        {
            Console.WriteLine("Thong tin hinh tron: ");
            Console.WriteLine($"Toa do tam hinh tron: D({diem.x},{diem.y})");
            Console.WriteLine($"Chu vi hinh tron: {ChuViHinhTron()}, dien tich hinh tron: {DienTichHinhTron()}");
        }
        public class hinhTron
        {
            public hinhTron()
            {
                HinhTron ht = new HinhTron();
                ht.HienThiHinhTron();
            }
        }
    }
}

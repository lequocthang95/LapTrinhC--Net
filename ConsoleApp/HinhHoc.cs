using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class HinhHoc
    {
        private string TenHH;
        public HinhHoc()
        {
            Console.WriteLine("Nhap ten hinh hoc ban muon thuc thi: ");
            TenHH = Console.ReadLine();
            switch (TenHH)
            {
                case "hinh tron":
                    HinhTron.hinhTron hinhTron = new HinhTron.hinhTron();
                    break;
                case "tam giac":
                    Tamgiac.hienThi tg = new Tamgiac.hienThi();
                    break;
                case "hinh chu nhat":
                    HinhChuNhat.hinhChuNhat hcn =new HinhChuNhat.hinhChuNhat();
                    break;
                default:
                    Console.WriteLine("Vui long nhap dung ten hinh hoc ban muon thuc thi!");
                    break;
            }
        }
    }
}

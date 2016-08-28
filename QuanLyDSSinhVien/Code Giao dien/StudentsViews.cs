using QuanLyDSSinhVien.Code_Xu_ly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDSSinhVien.Code_Giao_dien
{
    class StudentsViews
    {
        public static void Menu()
        {
            Console.WriteLine("==============Quan ly DS sinh vien==================");
            Console.WriteLine("  1. Hien thi danh sach sinh vien");
            Console.WriteLine("  2. Them");
            Console.WriteLine("  3. Sua");
            Console.WriteLine("  4. Xoa");
        }

        public static void HienThiDS(List<Student> lst)
        {
            lst.ForEach( x => Console.WriteLine(x.ToString()) );
        }
    }
}

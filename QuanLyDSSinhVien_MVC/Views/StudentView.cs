using QuanLyDSSinhVien_MVC.Controllers;
using QuanLyDSSinhVien_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDSSinhVien_MVC.Views
{
    public class StudentView
    {
        public static void ShowHeader()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("|                     Chuong trinh                           |");
            Console.WriteLine("|                 Quan ly DS Sinh vien                       |");
            Console.WriteLine("==============================================================");
        }

        public static void Menu()
        {
            Console.WriteLine(" 1. Hien thi danh sach.");
            ConsoleKey c = Console.ReadKey().Key;

            switch (c)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    RunOption1();
                    break;
                default:
                    break;
            }
        }

        public static void RunOption1()
        {
            StudentController ctrl = new StudentController();
            List<Student> lst = ctrl.LstStudent;
            // do something
        }
    }
}

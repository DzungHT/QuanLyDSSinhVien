using QuanLyDSSinhVien.Code_Giao_dien;
using QuanLyDSSinhVien.Code_Xu_ly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyDSSinhVien
{
    

    class Program
    {
        static void Main(string[] args)
        {
            StudentManager smn = new StudentManager();
            Student st;

            // Cách khởi tạo thứ nhất. Gán giá trị cho thuộc tính
            st = new Student();
            st.StudentID = 1;
            st.FirstName = "Dung";
            st.LastName = "Hoang Tri";
            smn.AddStudent(st);

            // Cách khởi tạo thứ 2: Sử dụng constructor có tham số
            st = new Student(3, "Nguyen Duc Anh");
            smn.AddStudent(st);

            // Cách khởi tạo thứ 3
            st = new Student() { StudentID = 2, FirstName = "Duc", LastName = "Nguyen Trung" };
            smn.AddStudent(st);

            //smn.LstStudent.Sort();
            Console.WriteLine("Sap xep theo ID:");
            StudentsViews.HienThiDS(smn.LstStudent);

            Console.WriteLine("===============================================");
            IComparer<Student> comparer = new StudentCompareByFisrname();
            //smn.LstStudent.Sort(comparer);
            smn.Sort(comparer);
            Console.WriteLine("Sap xep theo Ten:");

            StudentsViews.HienThiDS(smn.LstStudent);




            Console.ReadKey();
        }
    }
}

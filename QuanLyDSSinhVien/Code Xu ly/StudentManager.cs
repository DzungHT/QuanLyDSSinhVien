using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDSSinhVien.Code_Xu_ly
{
    /// <summary>
    /// Có chức năng quản lý danh sách sinh viên
    /// </summary>
    class StudentManager
    {
        /// <summary>
        /// Trường dữ liệu
        /// </summary>
        private List<Student> lstStudent;

        /// <summary>
        /// Đây là thuộc tính
        /// </summary>
        public List<Student> LstStudent
        {
            get
            {
                return lstStudent;
            }
        }

        public StudentManager()
        {
            lstStudent = new List<Student>();
        }

        /// <summary>
        /// Thêm 1 sinh viên
        /// </summary>
        /// <param name="stu">đối tượng chứa dữ liệu muốn thêm.</param>
        public void AddStudent(Student stu)
        {
            /*
             * Kiểm tra trong lstStudent có stu chưa (dựa vào StudentID).
             * Nếu có thì thôi không add nữa.
             * Ngược lại, thì add stu vào lstStudent
             */
            // vi du
            // Student[] arr = new Student[100];
            // arr[0];  =>  0 la chi so index cua phan tu dau tien.

            int index = lstStudent.FindIndex(x => x.StudentID == stu.StudentID); // lamda expression, delegate

            if (index == -1)
            {
                // trong lstStudent không có đối tượng student
                lstStudent.Add(stu);
            }
            else
            {
                // trong lstStudent đã tồn tại 1 phần tử nằm ở vị trí index.
                // bỏ qua không làm gì hết.
            }
        }

        /// <summary>
        /// Xóa sinh viên
        /// </summary>
        /// <param name="stu">Đối tượng có chữa StudentID cần xóa</param>
        public void DelStudent(Student stu)
        {
            int index = lstStudent.FindIndex(x => x.StudentID == stu.StudentID);

            if (index != -1)
            {
                // Nếu sinh viên có tồn tại trong lstStudent thì xóa
                lstStudent.RemoveAt(index);
            }
            else
            {
                // Chưa tồn tại sinh viên có StudentID tồn tại trong danh sách
                // không làm gì hết
            }
        }

        /// <summary>
        /// Cập nhật thông tin sinh viên
        /// </summary>
        /// <param name="stu">Đối tượng chứa dữ liệu muốn cập nhật</param>
        public void UpdateStudent(Student stu)
        {
            int index = lstStudent.FindIndex(x => x.StudentID == stu.StudentID); // lamda expression, delegate

            if (index != -1)
            {
                // nếu tồn tại student trong danh sách thì gán lại giá trị thứ index = student
                lstStudent[index].FirstName = stu.FirstName;
                lstStudent[index].LastName = stu.LastName;
            }
            else
            {
                // trong lstStudent đã tồn tại 1 phần tử nằm ở vị trí index.
                // bỏ qua không làm gì hết.
            }
        }

        /// <summary>
        /// Viết để cho biết nó dùng interface để làm gì mà không
        /// dùng class để truyền vào tham số.
        /// 
        /// Là vì 
        /// </summary>
        /// <param name="comparer"></param>
        public void Sort(IComparer<Student> comparer)
        {
            Student st1, st2;
            for (int i = 0; i < LstStudent.Count - 1; i++)
            {
                st1 = LstStudent[i];
                for (int j = i + 1; j < LstStudent.Count; j++)
                {
                    st2 = lstStudent[j];
                    int iKetQuaSoSanh = comparer.Compare(st1, st2);
                    if (iKetQuaSoSanh < 0)
                    {
                        // st1 < st2
                        // Do something
                    }
                    else
                    {
                        if (iKetQuaSoSanh > 0)
                        {
                            // st1 > st2
                            lstStudent[j] = st1;
                            lstStudent[i] = st2;
                        }
                        else
                        {
                            // st1 = st2
                            // Do something
                        }
                    }
                }
            }
        }

        public List<Student> SearchByID(int ID)
        {
            return lstStudent.FindAll(x => x.StudentID == ID);
        }

        public List<Student> SearchByName(string name)
        {
            return lstStudent.FindAll(x => x.Fullname.Contains(name));
        }
    }
}

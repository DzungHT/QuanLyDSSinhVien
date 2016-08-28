using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDSSinhVien_MVC.Models
{
    /// <summary>
    /// Lưu trữ thôn tin 1 sinh viên
    /// </summary>
    public class Student : IComparable<Student>
    {
        /// <summary>
        /// Mã sinh viên. Dùng để phân biệt các sinh viên với nhau.
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Trường dữ liệu
        /// </summary>
        private string fullname;

        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName
        {
            get
            {
                // cắt fullname theo các dấu cách
                // Trả về phần tử cuối cùng.
                string[] arr = Fullname.Split(' ');
                if (arr.Length > 1)
                {
                    return arr[arr.Length - 1];
                }
                else
                {
                    return Fullname;
                }
            }
            set
            {
                string firstname = value;
                // Bỏ dấu cách ở đầu và cuối chuỗi rồi gắn cho fullname;
                Fullname = LastName + " " + firstname.Trim();
            }
        }

        /// <summary>
        /// Họ
        /// </summary>
        public string LastName
        {
            get
            {
                string[] arr = Fullname.Split(' ');
                string s = string.Empty;
                // Nếu arr.Lenth > 1 thì cộng chuỗi bỏ phần tử cuối cùng
                // Ngược lại, gán s = fullname;
                if (arr.Length > 1)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        s += arr[i];
                    }
                }
                else
                {
                    s = Fullname;
                }
                return s;
            }
            set
            {
                string lastname = value;
                // Bỏ dấu cách ở đầu và cuối chuỗi rồi gắn cho fullname;
                Fullname = lastname.Trim() + " " + FirstName;
            }
        }

        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public Student()
        {
            this.StudentID = 0;
            this.Fullname = "";
        }
        public Student(int _id, string _fullname)
        {
            this.StudentID = _id;
            this.Fullname = _fullname;
        }

        /// <summary>
        /// So sánh 2 đối tượng dựa vào StudentID
        /// </summary>
        /// <param name="other">đối tượng so sánh</param>
        /// <returns>
        /// Trả về giá trị âm: Đối tượng đang xét nhỏ hơn đối tượng truyền vào
        /// Trả về giá 0 : 2 đối tượng bằng nhau.
        /// trả về giá dương: Đối tượng đang xét lớn hơn đối tượng truyền vào
        /// </returns>
        public int CompareTo(Student other)
        {
            if (this.StudentID > other.StudentID)
            {
                return 1;
            }
            else
                if (this.StudentID < other.StudentID)
            {
                return -1;
            }
            else
                    if (this.StudentID == other.StudentID)
            {
                return 0;
            }
            return this.StudentID.CompareTo(other.StudentID);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} | {1}", this.StudentID, this.Fullname);
            return builder.ToString();
        }
    }

    class StudentCompareByFisrname : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}

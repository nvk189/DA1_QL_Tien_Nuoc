using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public static class Tool
    {
        public static string Chuan_Hoa_Chuoi(string a)
        {
            string s = "";
            //neu chuoi trong thi khong lam gi ca

            if (a == "")
            {

            }
            else
            {
                //cat bo khoang trnga thua o dau va cuoi chuoi sau do chuyen va chu thuong
                a = a.Trim().ToLower();
                while (a.IndexOf("\t") >= 0)
                {
                    //lay ra tung ky tu khi nao gap tab thi thay the bang 1 dau cach
                    a = a.Replace("\t", " ");
                }
                while (a.IndexOf("  ") >= 0)
                {
                    //lay ra chi so cua tung ky tu khi nao gap 2 dau cach thi thay the bang 1 dau cach
                    a = a.Replace("  ", " ");
                }

                // gap dau cach la cat thanh chuoi
                string[] arr = a.Split(' ');
                foreach (string item in arr)
                {
                    // cat chuoi vaf chuyen chu cai tu vi tri thu 0 thanh chu hoa
                    // chuyen cac ky tu tu vi tri 1 thanh thuong
                    s += item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + " ";
                }
            }
            return s;
        }

         
        //hàm kiểm tra độ dài xâu

        public static bool CheckStringLength(string inputString)
        {
            if (inputString.Length >6)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        //độ dài số điện thoaik
        public static bool CheckStringLengthint(string inputString)
        {
            if (inputString.Length ==10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // hàm kiểm tra TenDangnhập
        public static bool CheckFirstCharacter(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return false; // Xâu trống hoặc null, trả về false
            }

            char firstChar = inputString[0];
            if (firstChar == '_' || (firstChar >= 'a' && firstChar <= 'z') || (firstChar >= 'A' && firstChar <= 'Z'))
            {
                return true; // Ký tự đầu tiên thỏa mãn điều kiện, trả về true
            }
            else
            {
                return false; // Ký tự đầu tiên không thỏa mãn điều kiện, trả về false
            }
        }


        public  static bool CheckWhitespace(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return false; // Xâu trống hoặc null, trả về false
            }

            if (inputString.Contains(" "))
            {
                return false; // Xâu chứa khoảng trắng, trả về false
            }
            else
            {
                return true; // Xâu không chứa khoảng trắng, trả về true
            }
        }

        //hàm  chuyển đổi từ Datagriview sang bảng DataTable

        public static DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Tạo cột trong DataTable từ các cột trong DataGridView
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Thêm dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }


        // tạo cột thứ tự cho datagriview



       
    }
}

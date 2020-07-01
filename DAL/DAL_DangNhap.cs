using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_DangNhap : DBConnect
    {
        public bool ktThanhVien(DTO_DangNhap tv)
        {
            try
            {
       
                _conn.Open();
                string sql = "select *from NguoiDung where TaiKhoan=@0";
                sql = "select *from NguoiDung where MatKhau=@1";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@0", tv.nguoiDung_taiKhoan);
                cmd.Parameters.AddWithValue("@1", tv.nguoiDung_matKhau);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    return true;                
                }
                else
                {
                    return false;
                }
          
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }

       
    }
}

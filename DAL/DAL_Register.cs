using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
        public class DAL_Register:DBConnect
        {
        public bool themTaiKhoan(DTO_Register tk)
        {

            try
            {
                _conn.Open();
                string cm = "insert into NguoiDung values(@taikhoan,@matkhau,@phanquyen,@ten)";
                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@taikhoan", tk.nguoiDung_taiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", tk.nguoiDung_matKhau);
                cmd.Parameters.AddWithValue("@phanquyen",tk.nguoiDung_phanQuyen);
                cmd.Parameters.AddWithValue("@ten", tk.nguoiDung_Ten);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
        public bool CheckTrungTaiKhoan(string taikhoan)
        {
            try
            {
                _conn.Open();
                string sql = "select * from NguoiDung where TaiKhoan='" + taikhoan + "' ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool SuaTaiKhoan(DTO_Register tk)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string cm = "UPDATE NguoiDung SET MatKhau=@matkhau,PhanQuyen=@phanquyen,TenNhanVien=@ten where TaiKhoan=@taikhoan";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@taikhoan", tk.nguoiDung_taiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", tk.nguoiDung_matKhau);
                cmd.Parameters.AddWithValue("@phanquyen", tk.nguoiDung_phanQuyen);
                cmd.Parameters.AddWithValue("@ten", tk.nguoiDung_Ten);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {

                _conn.Close();
            }

            return false;
        }
        public bool XoaTaiKhoan(DTO_Register tk)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string cm = "Delete NguoiDung where TaiKhoan=@taikhoan";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@taikhoan", tk.nguoiDung_taiKhoan);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

                _conn.Close();
            }

            return false;
        }
    }
}

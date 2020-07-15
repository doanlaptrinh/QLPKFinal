using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public bool CheckTrungID(string id)
        {
            try
            {
                _conn.Open();
                string sql = "select *from NhanVien where ID='" + id + "' ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true)
                {
                    return true;
                }

            }
            catch(Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            
            try
            {
                _conn.Open();
                // Create List Sql Parameter
                string cm = "insert into NhanVien values(@ID,@HoTen,@GioiTinh,@NgaySinh,@QueQuan,@SoDienThoai,@Email,@ChucVu)";
                
                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", nv.nhanVien_id);
                cmd.Parameters.AddWithValue("@HoTen", nv.nhanVien_hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.nhanVien_gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.nhanVien_ngaySinh);
                cmd.Parameters.AddWithValue("@QueQuan", nv.nhanVien_queQuan);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.nhanVien_sodt);
                cmd.Parameters.AddWithValue("@Email", nv.nhanVien_email);
                cmd.Parameters.AddWithValue("@ChucVu", nv.nhanVien_chucVu);
                
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
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string cm= "UPDATE NhanVien SET HoTen=@hoten,GioiTinh=gioitinh,NgaySinh=@ngaysinh,QueQuan=@quequan,SoDienThoai=@sodienthoai,Email=@email,ChucVu=@chucvu Where ID=@id";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@id", nv.nhanVien_id);
                cmd.Parameters.AddWithValue("@hoten", nv.nhanVien_hoTen);
                cmd.Parameters.AddWithValue("@gioitinh", nv.nhanVien_gioiTinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.nhanVien_ngaySinh);
                cmd.Parameters.AddWithValue("@quequan", nv.nhanVien_queQuan);
                cmd.Parameters.AddWithValue("@sodienthoai", nv.nhanVien_sodt);
                cmd.Parameters.AddWithValue("@email", nv.nhanVien_email);
                cmd.Parameters.AddWithValue("@chucvu", nv.nhanVien_chucVu);
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
        public bool XoaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                string cm = "Delete NhanVien where ID =@id";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@id", nv.nhanVien_id);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Thuoc:DBConnect
    {
        public bool ThemThuoc(DTO_Thuoc th)
        {

            try
            {
                _conn.Open();
                // Create List Sql Parameter
                string cm = "insert into DonThuoc values(@ID,@TenThuoc,@DonViTinh,@LieuDung,@DonGia,@GhiChu)";

                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", th.thuoc_id);
                cmd.Parameters.AddWithValue("@TenThuoc", th.thuoc_tenthuoc);
                cmd.Parameters.AddWithValue("@DonViTinh", th.thuoc_soLuong);
                cmd.Parameters.AddWithValue("@LieuDung", th.thuoc_lieuDung);
                cmd.Parameters.AddWithValue("@DonGia", th.thuoc_donGia);
                cmd.Parameters.AddWithValue("@GhiChu", th.thuoc_ghiChu);
                

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
        public bool SuaThuoc(DTO_Thuoc th)
        {

            try
            {
                _conn.Open();
                // Create List Sql Parameter
                string cm = "update  DonThuoc set TenThuoc=@tenthuoc,DonViTinh=@donvitinh,LieuDung=@lieudung,DonGia=@dongia,GhiChu=@ghichu where ID=@id";

                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", th.thuoc_id);
                cmd.Parameters.AddWithValue("@tenthuoc", th.thuoc_tenthuoc);
                cmd.Parameters.AddWithValue("@donvitinh", th.thuoc_soLuong);
                cmd.Parameters.AddWithValue("@lieudung", th.thuoc_lieuDung);
                cmd.Parameters.AddWithValue("@dongia", th.thuoc_donGia);
                cmd.Parameters.AddWithValue("@ghichu", th.thuoc_ghiChu);


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
        public bool XoaThuoc(DTO_Thuoc th)
        {
            try
            {
                _conn.Open();
                string cm = "Delete DonThuoc where ID =@iD";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@iD", th.thuoc_id);
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
        public bool CheckTrungID(string id)
        {
            try
            {
                _conn.Open();
                string sql = "select *from DonThuoc where ID='" + id + "' ";
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
    }
}

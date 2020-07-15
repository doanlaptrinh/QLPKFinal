using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_BenhNhan:DBConnect
    {
        public bool ThemBenhNhan(DTO_BenhNhan bn)
        {

            try
            {
                _conn.Open();
                string cm = "insert into BenhNhan values(@ID,@TenBenhNhan,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi,@GhiChu)";

                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", bn.benhNhan_id);
                cmd.Parameters.AddWithValue("@TenBenhNhan", bn.benhNhan_tenBenhNhan);
                cmd.Parameters.AddWithValue("@GioiTinh", bn.benhNhan_gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bn.benhNhan_ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", bn.benhNhan_diaChi);
                cmd.Parameters.AddWithValue("@DienThoai", bn.benhNhan_dienThoai);
                cmd.Parameters.AddWithValue("@GhiChu", bn.benhNhan_ghiChu);

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
        public bool CheckTrungID(string id)
        {
            try
            {
                _conn.Open();
                string sql = "select *from BenhNhan where ID='" + id + "' ";
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
        public bool SuaBenhNhan(DTO_BenhNhan bn)
        {
            try
            {
                _conn.Open();
                string cm = "UPDATE BenhNhan SET TenBenhNhan=@tenBenhNhan,GioiTinh=@gioiTinh,NgaySinh=@ngaysinh,DiaChi=@diaChi,DienThoai=@dienThoai,GhiChu = @ghiChu Where ID=@iD";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@iD", bn.benhNhan_id);
                cmd.Parameters.AddWithValue("@tenBenhNhan", bn.benhNhan_tenBenhNhan);
                cmd.Parameters.AddWithValue("@gioiTinh", bn.benhNhan_gioiTinh);
                cmd.Parameters.AddWithValue("@ngaysinh", bn.benhNhan_ngaySinh);
                cmd.Parameters.AddWithValue("@diaChi", bn.benhNhan_diaChi);
                cmd.Parameters.AddWithValue("@dienThoai", bn.benhNhan_dienThoai);
                cmd.Parameters.AddWithValue("@ghiChu", bn.benhNhan_ghiChu);
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
        public bool XoaBenhNhan(DTO_BenhNhan bn)
        {
            try
            {
                _conn.Open();
                string cm = "Delete BenhNhan where ID =@iD";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@iD", bn.benhNhan_id);
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

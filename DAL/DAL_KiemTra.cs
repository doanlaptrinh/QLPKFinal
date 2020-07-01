using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KiemTra:DBConnect
    {
        public bool ThemKiemTra(DTO_KiemTra kt)
        {

            try
            {
                _conn.Open();
                // Create List Sql Parameter
                string cm = "insert into KiemTra values(@ID,@KiemTra,@HoaDon)";

                SqlCommand cmd;
                cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@ID", kt.kiemtra_id);
                cmd.Parameters.AddWithValue("@KiemTra", kt.kiemtra_tenkiemtra);
                cmd.Parameters.AddWithValue("@HoaDon", kt.kiemtra_donGia);
               
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
                string sql = "select *from KiemTra where ID='" + id + "' ";
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

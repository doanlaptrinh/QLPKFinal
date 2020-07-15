using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DoanhThu:DBConnect
    {
        public DataTable LocDoanhThu(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            try
            {

                _conn.Open();
                string sql = " select * from DoanhThu where ThoiGian>@ngaybatdau and ThoiGian<@ngayketthuc ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                cmdd.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
                cmdd.Parameters.AddWithValue("@ngayketthuc", ngayketthuc);
                cmdd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                DataTable data = new DataTable();
                data = null;
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmdd;
                ad.Fill(ds);
                data = ds.Tables[0];
                return data;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}

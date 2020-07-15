using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_KhamBenh : DBConnect
    {
        public bool ThemKhamBenh(string id, string ten)
        {
            try
            {
                _conn.Open();
                string sel = "";
                SqlCommand cmd = new SqlCommand(sel, _conn);
                sel = "insert into LichSuKham(IDBenhNhan,TenBenhNhan,NgayKham,TenBacSi) values(@iD,(select TenBenhNhan from BenhNhan Where ID=@iD),getdate(),@tenbs)";
                cmd = new SqlCommand(sel, _conn);
                cmd.Parameters.AddWithValue("@iD", id);
                cmd.Parameters.AddWithValue("@tenbs", ten);
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
        public bool SuaKhamBenh(string id,string chuandoan,string ghichu)
        {
            try
            {
                _conn.Open();
                string sel = "";
                SqlCommand cmd = new SqlCommand(sel, _conn);
                sel = @"update LichSuKham set ChuanDoan=@chuandoan,GhiChuKham=@ghichukham where IDPhienKham=@id ";
                cmd = new SqlCommand(sel, _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@chuandoan", chuandoan);
                cmd.Parameters.AddWithValue("@ghichukham", ghichu);
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
                    return false;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return true;
        }
        public bool XoaBenhAn(string id)
        {
            try
            {
                _conn.Open();
                string cm = "Delete LichSuKham where IDPhienKham =@id";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@id", id);
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
        public bool ThemKiemtra(string id,string idpk)
        {
            try
            {
                int pk = Convert.ToInt32(idpk);
                _conn.Open();
                string sel = @"insert into PhieuKiemTra(LoaiKiemTra,GiaTien,IDPhienKham) values((select TenKiemTra from KiemTra Where TenKiemTra=@iD),(select HoaDon from KiemTra Where TenKiemTra=@iD),@idpk)";
                SqlCommand cmd = new SqlCommand(sel, _conn);
                cmd.Parameters.AddWithValue("@iD", id);
                cmd.Parameters.AddWithValue("@idpk", pk);
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
        public bool CheckTrungKT(string id,string idpk)
        {
            try
            {
                _conn.Open();
                string sql = "select *from PhieuKiemTra where LoaiKiemTra LIKE N'" + id + "' and IDPhienKham=@id";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                cmdd.Parameters.AddWithValue("@id", idpk);
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
        public bool XoaKiemTra(string id)
        {
            try
            {
                _conn.Open();
                string cm = "Delete PhieuKiemTra where ID=@id";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@id", id);
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
        public bool ThemDonThuoc(string id,int sl,int idphienkham)
        {
            try
            {
                _conn.Open();
                string sel = @"insert into PhieuDonThuoc(TenThuoc, DonViTinh,SoLuong, LieuDung, GhiChu, DonGia, IDPhienKham) values((select TenThuoc from DonThuoc Where TenThuoc = @ID),(select DonViTinh from DonThuoc Where TenThuoc = @ID),@SoLuong,(select LieuDung from DonThuoc Where TenThuoc = @ID),(select GhiChu from DonThuoc Where TenThuoc = @ID),((select DonGia from DonThuoc Where TenThuoc = @ID)*@SoLuong),@idphienkham)";
                SqlCommand cmd = new SqlCommand(sel, _conn);
                cmd.Parameters.AddWithValue("@iD", id);
                cmd.Parameters.AddWithValue("@soluong", sl);
                cmd.Parameters.AddWithValue("@idphienkham", idphienkham);
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
        public bool CheckTrungThuoc(string id,string idpk)
        {
            try
            {
                _conn.Open();
                string sql = "select *from PhieuDonThuoc where TenThuoc LIKE N'" + id + "'and IDPhienKham=@id ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                cmdd.Parameters.AddWithValue("@id", idpk);
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
        public bool XoaDonThuoc(string id)
        {
            try
            {
                _conn.Open();
                string cm = "Delete PhieuDonThuoc where ID=@id";
                SqlCommand cmd = new SqlCommand(cm, _conn);
                cmd.Parameters.AddWithValue("@id", id);
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
        public int Getidphienkham()
        {
            try
            {
                _conn.Open();
                string sql = " select max(IDPhienKham) from LichSuKham ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true)
                {
                    int ID = Convert.ToInt32(dta[0]);
                    dta.Close();
                    return ID;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return 0;
        }
        public string Getidbacsi()
        {
            try
            {
                DTO_DangNhap tk = new DTO_DangNhap();
                _conn.Open();
                string sql = " select max(IDPhienKham) from LichSuKham ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                SqlDataReader dta = cmdd.ExecuteReader();
                if (dta.Read() == true)
                {
                    int ID = Convert.ToInt32(dta[0]);
                    dta.Close();
                    return "";
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable Xemdonthuoc(string id)
        {
            try
            {
                
                _conn.Open();
                string sql = " select * from PhieuDonThuoc where IDPhienKham=@id ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                cmdd.Parameters.AddWithValue("@id", id);
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
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable Xemkiemtra(string id)
        {
            try
            {

                _conn.Open();
                string sql = " select * from PhieuKiemTra where IDPhienKham=@id ";
                SqlCommand cmdd = new SqlCommand(sql, _conn);
                cmdd.Parameters.AddWithValue("@id", id);
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
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public bool ThemDoanhThu(int idphienkham)
        {
            try
            {
                _conn.Open();
                string sel = @"insert into DoanhThu values (@id,(select NgayKham from LichSuKham where IDPhienKham=@id),
                (select Sum(DonGia)+(select SUM(GiaTien)
                from LichSuKham join PhieuKiemTra on LichSuKham.IDPhienKham=PhieuKiemTra.IDPhienKham
                where LichSuKham.IDPhienKham=@id) 
                from LichSuKham join PhieuDonThuoc on LichSuKham.IDPhienKham=PhieuDonThuoc.IDPhienKham
                where LichSuKham.IDPhienKham=@id))";
                SqlCommand cmd = new SqlCommand(sel, _conn);
                cmd.Parameters.AddWithValue("@id", idphienkham);
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
    }
}

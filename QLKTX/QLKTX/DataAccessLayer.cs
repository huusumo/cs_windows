using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class DataAccessLayer
    {
        #region FormDN

        public bool CheckTK(TaiKhoan tk)
        {
            string sql = "select * from TaiKhoan where Taikhoan like @Taikhoan and Matkhau like @Matkhau";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@Taikhoan", SqlDbType.Char).Value = tk.Taikhoan;
                cmd.Parameters.Add("@Matkhau", SqlDbType.Char).Value = tk.Matkhau;
                SqlDataReader reader = cmd.ExecuteReader();

                bool ret = reader.Read();

                connection.Close();

                return ret;
            }
        }

        #endregion

        #region FormQLKN

        public DataTable GetAllKN()
        {
            DataTable datable = new DataTable();

            string sql = "select * from KhuNha";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool ThemKN(KhuNha kn)
        {
            string sql = "insert into KhuNha values(@MaKN, @SoTang, @SoPhong, @ViTri, @TinhXay, @TruongKN, @TienDienNuoc)";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaKN", SqlDbType.NChar).Value = kn.MaKN;
                    cmd.Parameters.Add("@SoTang", SqlDbType.Int).Value = kn.SoTang;
                    cmd.Parameters.Add("@SoPhong", SqlDbType.Int).Value = kn.SoPhong;
                    cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = kn.ViTri;
                    cmd.Parameters.Add("@TinhXay", SqlDbType.NVarChar).Value = kn.TinhXay;
                    cmd.Parameters.Add("@TruongKN", SqlDbType.NVarChar).Value = kn.TruongKN;
                    cmd.Parameters.Add("@TienDienNuoc", SqlDbType.Float).Value = kn.TienDienNuoc;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool SuaKN(KhuNha kn)
        {
            string sql = "update KhuNha set SoTang=@SoTang, SoPhong=@SoPhong, ViTri=@ViTri, TinhXay=@TinhXay, TruongKhuNha=@TruongKN where MaKN=@MaKN";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaKN", SqlDbType.NChar).Value = kn.MaKN;
                    cmd.Parameters.Add("@SoTang", SqlDbType.Int).Value = kn.SoTang;
                    cmd.Parameters.Add("@SoPhong", SqlDbType.Int).Value = kn.SoPhong;
                    cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = kn.ViTri;
                    cmd.Parameters.Add("@TinhXay", SqlDbType.NVarChar).Value = kn.TinhXay;
                    cmd.Parameters.Add("@TruongKN", SqlDbType.NVarChar).Value = kn.TruongKN;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool XoaKN(KhuNha kn)
        {
            string sql = "delete from KhuNha where MaKN=@MaKN";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaKN", SqlDbType.Char).Value = kn.MaKN;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public DataTable TimKN(string key)
        {
            DataTable datable = new DataTable();

            string sql = "select * from KhuNha where MaKN like '%" + key + "%'";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool XoaAllKN()
        {
            string sql = "delete from KhuNha";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        #endregion

        #region FormPhong

        public DataTable GetAllPhong()
        {
            DataTable datable = new DataTable();

            string sql = "select * from Phong";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool ThemPhong(Phong phg)
        {
            string sql = "insert into Phong values(@MaPhong, @MaKN, @TruongPhong, @TienDienNuoc, @ChiTiet)";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = phg.MaPhong;
                    cmd.Parameters.Add("@MaKN", SqlDbType.NChar).Value = phg.MaKN;
                    cmd.Parameters.Add("@TruongPhong", SqlDbType.NChar).Value = phg.TruongPhong;
                    cmd.Parameters.Add("@TienDienNuoc", SqlDbType.Float).Value = phg.TienDienNuoc;
                    cmd.Parameters.Add("@ChiTiet", SqlDbType.NVarChar).Value = phg.ChiTiet;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool SuaPhong(Phong phg)
        {
            string sql = "update Phong set MaKN=@MaKN, TruongPhong=@TruongPhong, TienDienNuoc=@TienDienNuoc, ChiTiet=@ChiTiet where MaPhong=@MaPhong";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = phg.MaPhong;
                    cmd.Parameters.Add("@MaKN", SqlDbType.NChar).Value = phg.MaKN;                    
                    cmd.Parameters.Add("@TruongPhong", SqlDbType.NVarChar).Value = phg.TruongPhong;
                    cmd.Parameters.Add("@TienDienNuoc", SqlDbType.Float).Value = phg.TienDienNuoc;
                    cmd.Parameters.Add("@ChiTiet", SqlDbType.NVarChar).Value = phg.ChiTiet;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool XoaPhong(Phong phg)
        {
            string sql = "delete from Phong where MaPhong=@MaPhong";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = phg.MaPhong;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public DataTable TimPhong(string key)
        {
            DataTable datable = new DataTable();

            string sql = "select * from Phong where MaPhong like '%" + key + "%'";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool XoaAllPhong()
        {
            string sql = "delete from Phong";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        //
        public DataTable GetAllMaKN()
        {
            DataTable datable = new DataTable();

            string sql = "select MaKN from KhuNha";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        #endregion

        #region FormQLSV

        public DataTable GetAllSV()
        {
            DataTable datable = new DataTable();

            string sql = "select * from SinhVien";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool ThemSV(SinhVien sv)
        {
            string sql = "insert into SinhVien values(@MaSV, @HoTenSV, @MaP, @NgaySinh, @GioiTinh, @TrangThai, @MienGiam, @NgayVao, @DongTien, @ChucVu)";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaSV", SqlDbType.NChar).Value = sv.MaSV;
                    cmd.Parameters.Add("@HoTenSV", SqlDbType.NVarChar).Value = sv.HoTenSV;
                    cmd.Parameters.Add("@MaP", SqlDbType.NChar).Value = sv.MaPhong;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = sv.NgaySinh;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = sv.GioiTinh;
                    cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = sv.TrangThai;
                    cmd.Parameters.Add("@MienGiam", SqlDbType.NVarChar).Value = sv.MienGiam;
                    cmd.Parameters.Add("@NgayVao", SqlDbType.Date).Value = sv.NgayVao;
                    cmd.Parameters.Add("@DongTien", SqlDbType.Bit).Value = sv.DongTien;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = sv.ChucVu;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool SuaSV(SinhVien sv)
        {
            string sql = "update SinhVien set HoTenSV=@HoTenSV, MaPhong=@MaPhong, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, TrangThai=@TrangThai, MienGiam=@MienGiam, NgayVao=@NgayVao, DongTien=@DongTien, ChucVu=@ChucVu where MaSV=@MaSV";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = sv.MaSV;
                    cmd.Parameters.Add("@HoTenSV", SqlDbType.NVarChar).Value = sv.HoTenSV;
                    cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = sv.MaPhong;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = sv.NgaySinh;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = sv.GioiTinh;
                    cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = sv.TrangThai;
                    cmd.Parameters.Add("@MienGiam", SqlDbType.NVarChar).Value = sv.MienGiam;
                    cmd.Parameters.Add("@NgayVao", SqlDbType.Date).Value = sv.NgayVao;
                    cmd.Parameters.Add("@DongTien", SqlDbType.Bit).Value = sv.DongTien;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = sv.ChucVu;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool XoaSV(SinhVien sv)
        {
            string sql = "delete from SinhVien where MaSV=@MaSV";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = sv.MaSV;
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public DataTable TimSV(string key)
        {
            DataTable datable = new DataTable();

            string sql = "select * from SinhVien where MaSV like '%" + key + "%'";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        public bool XoaAllSV()
        {
            string sql = "delete from SinhVien";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        //
        public DataTable GetAllMaPhong()
        {
            DataTable datable = new DataTable();

            string sql = "select MaPhong from Phong";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datable);

                connection.Close();
            }
            return datable;
        }

        #endregion      
    }
}

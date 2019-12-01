using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class DataAccessLayer
    {
        public DataTable GetAllSV()
        {
            DataTable datable = new DataTable();

            string sql = "select MaSV as [Mã sinh viên], TenSV as [Tên sinh viên], Namsinh as [Năm sinh] from SinhVien";
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
            string sql = "insert into SinhVien values(@MaSV, @TenSV, @Namsinh)";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = sv.MaSV;
                    cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                    cmd.Parameters.Add("@Namsinh", SqlDbType.Int).Value = sv.Namsinh;
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
            string sql = "update SinhVien set TenSV=@TenSV, Namsinh=@Namsinh where MaSV=@MaSV";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@MaSV", SqlDbType.Char).Value = sv.MaSV;
                    cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                    cmd.Parameters.Add("@Namsinh", SqlDbType.Int).Value = sv.Namsinh;
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

            string sql = "select MaSV as [Mã sinh viên], TenSV as [Tên sinh viên], Namsinh as [Năm sinh] from SinhVien where MaSV like '%" + key + "%'";
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
    }
}

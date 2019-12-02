using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginForm
{
    class DataAccessLayer
    {
        #region FormLogin

        public bool CheckTK(TaiKhoan tk)
        {
            string sql = "select * from TaiKhoan where Taikhoan like @Taikhoan and Matkhau like @Matkhau";
            using (SqlConnection connection = new SqlConnection(DataConnection.ConnectDatabase))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.Add("@Taikhoan", SqlDbType.Char).Value = tk.Taikhoan;
                    cmd.Parameters.Add("@Matkhau", SqlDbType.Char).Value = tk.Matkhau;
                    SqlDataReader reader = cmd.ExecuteReader();

                    bool ret;
                    if (reader.Read() == true)
                        ret = true;
                    else
                        ret = false;

                    connection.Close();

                    return ret;
                }
                catch
                {
                    return false;
                }
            }
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

        #endregion
    }
}

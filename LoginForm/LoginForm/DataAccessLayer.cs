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
    }
}

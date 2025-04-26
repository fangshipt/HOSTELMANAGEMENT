using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=hostel;Integrated Security=True;";
            return con;
        }

        public DataSet getData(String query, SqlParameter[] parameters = null)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            // Nếu có tham số, thêm chúng vào câu lệnh SQL
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);  // Thêm các tham số vào câu lệnh SQL
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);  // Lấy dữ liệu vào DataSet
            return ds;
        }
        public void setData(String query, String msg, SqlParameter[] parameters = null)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

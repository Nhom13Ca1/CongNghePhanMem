using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWinform
{
    public class QL_NguoiDung
    {
        public int check_config()
        {
            if (Properties.Settings.Default.QLHSConnectionString == string.Empty)
                return 1;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.QLHSConnectionString);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public int check_users(string user, string pass)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from GIAOVIEN where MAGIAOVIEN ='" + user + "' and MATKHAU ='" + pass + "'", Properties.Settings.Default.QLHSConnectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
                return 1;
            else
                return 2;
        }
        public DataTable getservernames()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable getDBnames(string server, string user, string pass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + server + "\\SQL2012" + ";Initial Catalog=master;User ID=" + user + ";pwd=" + pass + "");
            da.Fill(dt);
            return dt;
        }
    }
}

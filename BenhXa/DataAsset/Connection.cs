using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenhXa.DataAsset
{
   public class Connection
    {
        SqlConnection conn;
        private Exception ex = new Exception();
        //Chuỗi kết nối
        public static string constring = @"Data Source=LAPTOP-J8587HLD;Initial Catalog=QLKhamBenh;Integrated Security=True";

        public static object ConfigurationManager { get; private set; }

        public bool MoKetNoi()
        {
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DongKetNoi()
        {
            conn.Close();
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            cmd.ExecuteNonQuery();
        }
        public SqlConnection GetCon()
        {
            return this.conn;
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, constring);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public Exception GetEx()
        {
            return ex;
        }
        public void SetEx(Exception ex)
        {
            this.ex = ex;
        }

    }
}

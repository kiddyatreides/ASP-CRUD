using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LatihanASP
{
    public partial class Tambah : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void save(object sender, EventArgs e)
        {
            
                string sql = "insert into barang (nama,deskripsi,harga) values (@nama, @deskripsi, @harga)";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add(new SqlParameter("@nama", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@deskripsi", SqlDbType.Text));
                cmd.Parameters.Add(new SqlParameter("@harga", SqlDbType.Money));

                cmd.Parameters["@nama"].Value = nama.Text;
                cmd.Parameters["@deskripsi"].Value = deskripsi.Text;
                cmd.Parameters["@harga"].Value = harga.Text;

                int res = cmd.ExecuteNonQuery();

                conn.Close();

                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location = 'View.aspx';</script>");
            
        }
    }
}
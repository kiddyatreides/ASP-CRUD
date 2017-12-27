using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LatihanASP
{
    public partial class Create : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void save(Object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into barang (nama,deskripsi,harga) values (@nama, @deskripsi, @harga)";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 250));
                cmd.Parameters.Add(new SqlParameter("@deskripsi", SqlDbType.Text));
                cmd.Parameters.Add(new SqlParameter("@harga", SqlDbType.Money));

                cmd.Parameters["@nama"].Value = nama.Text.ToString();
                cmd.Parameters["@deskripsi"].Value = deskripsi.Text.ToString();
                cmd.Parameters["@harga"].Value = harga.Text.ToString();

                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location='View.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ ex.Message +"');</script>");
            }
        }
    }
}
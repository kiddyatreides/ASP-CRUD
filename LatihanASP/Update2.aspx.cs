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
    public partial class Update2 : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            getID();
        }

        protected void getID()
        {
            try
            {
                string id = this.Request["id"];
                string sql = "Select * from barang where id = @id";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    iduser.Text = dr["id"].ToString();
                    nama.Text = dr["nama"].ToString();
                    deskripsi.Text = dr["deskripsi"].ToString();
                    harga.Text = dr["harga"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write("<script>alert('" + e.Message + "'); </script>");
            }



        }

        protected void update(Object sender, EventArgs e)
        {
            try
            {
            string sql = "UPDATE barang SET nama = @nama, deskripsi = @deskripsi, harga = @harga WHERE id = @id";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@nama", SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@deskripsi", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@harga", SqlDbType.Money));

            string id = this.Request["id"];
            cmd.Parameters["@id"].Value = id;
            cmd.Parameters["@nama"].Value = nama.Text;
            cmd.Parameters["@deskripsi"].Value = deskripsi.Text;
            cmd.Parameters["@harga"].Value = harga.Text;

            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script>alert('"+ "Berhasil" +"');</script>");
            Response.Write("<script>window.location = 'View.aspx'</script>");
           }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('"+ ex.Message +"');</script>");
             }  
        }
    }
}
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
    public partial class Update : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = this.Request["id"];
                getID(id);
            }                
        }               

        protected void getID(string id)
        {
            string sql = "Select * from barang where id = @id";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                TextBox1.Text = dr["nama"].ToString();
                TextBox2.Text = dr["deskripsi"].ToString();
                TextBox3.Text = dr["harga"].ToString();
                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write("<script>alert('"+ e.Message +"'); </script>");
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

                string id = this.Request["id"];
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 5).Value = id;
                cmd.Parameters.Add("@nama", SqlDbType.VarChar, 250).Value = TextBox1.Text;
                cmd.Parameters.Add("@deskripsi", SqlDbType.Text).Value = TextBox2.Text;
                cmd.Parameters.Add("@harga", SqlDbType.Money).Value = TextBox3.Text.ToString();

                int res = cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Berhasil');</script>");
                Response.Write("<script>window.location = 'View.aspx'</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }
    }
}
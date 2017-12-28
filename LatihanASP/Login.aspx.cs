using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace LatihanASP
{
    public partial class Login : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nama_admin"] != null) // if it will not find Session user it will redirect to login page.
            {
                Response.Write("<script>alert('Kamu Sudah Login!');</script>");
                Response.Write("<script>window.location = 'View.aspx';</script>");
            }

        }

        protected void login(object sender, EventArgs e)
        {
            string sql = "select * from admins where username = @username and password = @password";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // Storee Session
                Session["id_admin"] = dr["id"].ToString();
                Session["nama_admin"] = dr["nama"].ToString();
                Session.Timeout = 60; //15min


                Response.Write("<script>alert('Selamat Datang " + dr["nama"].ToString() + " !');</script>");
                Response.Write("<script>window.location = 'View.aspx';</script>");
            }


        }

        protected void logout()
        {
            string nama_admin = Session["nama_admin"].ToString();
            Session.Remove("id_admin");
            Session.Remove("nama_admin");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            Response.Write("<script>alert('Berhasil Logout, Admin " + nama_admin + "');</script>");
            Response.Write("<script>window.location = 'View.aspx';</script>");

        }
    }
}
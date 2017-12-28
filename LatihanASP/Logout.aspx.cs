using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LatihanASP
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logout();
        }

        protected void logout()
        {
            string nama_admin = Session["nama_admin"].ToString();
            Session.Remove("id_admin");
            Session.Remove("nama_admin");
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            Response.Write("<script>alert('Berhasil Logout, " + nama_admin + "');</script>");
            Response.Write("<script>window.location = 'View.aspx';</script>");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LatihanASP
{
    public partial class Hapus : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = this.Request["id"];
            hapusData(id);
        }

        protected void hapusData(string id)
        {
            string sql = "delete from barang where id = @id";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Berhasil');</script>");
            Response.Write("<script>window.location = 'View.aspx';</script>");
        }


    }
}
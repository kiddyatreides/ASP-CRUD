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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           hapusData(this.Request["id"]);
        }

        protected void hapusData(string id)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
                string sql = "delete from barang where id = @id";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Berhasil Delete');</script>");
                Response.Write("<script>window.location = 'View.aspx'</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
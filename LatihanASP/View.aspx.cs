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
    public partial class View : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDataOrganisasi();
            if(this.Request["status"] == "Delete"){
                hapusData(this.Request["id"]);
            }
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
                Response.Write("<script>alert('Berhasil Update');</script>");
                Response.Write("<script>window.location = 'View.aspx'</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void GetDataOrganisasi()
        {
            string strSQL = "SELECT * FROM barang";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PlaceHolder_Data.Controls.Add(new LiteralControl("<tr>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["nama"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["deskripsi"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl(dr["harga"].ToString()));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("<a href='Update.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'>Edit</a> <a href='Delete.aspx?id=" + dr["id"].ToString() + "' class='btn btn-danger'>Hapus</a>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</td>"));
                PlaceHolder_Data.Controls.Add(new LiteralControl("</tr>"));
            }
            conn.Close();
        }
    }
}
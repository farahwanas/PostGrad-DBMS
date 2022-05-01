using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AddPublication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitaddpub(object sender, EventArgs e)
        {
            //test this
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addpub = new SqlCommand("AddPublication", conn);
            if (title.Text == "" || pubdate.Text == "" ||
                host.Text == "" || place.Text == "" || accepted.Text == "")
            {
                Response.Write("Please fill all the spaces ");
            }
            else
            {
                addpub.Parameters.Add(new SqlParameter("@title", title.Text));
                DateTime pubdate1 = DateTime.Parse(pubdate.Text);
                addpub.Parameters.Add(new SqlParameter("@pubdate", pubdate1));
                addpub.Parameters.Add(new SqlParameter("@host", host.Text));
                addpub.Parameters.Add(new SqlParameter("@place", place.Text));
                int accepted1 = Int16.Parse(accepted.Text);
                addpub.Parameters.Add(new SqlParameter("@accepted", accepted1));
                addpub.CommandType = CommandType.StoredProcedure;
                //ask is that how it should be linked only
                //check how to link to ongoing thesis
                conn.Open();
                addpub.ExecuteNonQuery();
                conn.Close();
                Response.Write("Successfully Added");

            }
        }
    }
}
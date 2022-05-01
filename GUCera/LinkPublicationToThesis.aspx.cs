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
    public partial class LinkPublicationToThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataAdapter publication = new SqlDataAdapter("ViewAllPublications", conn);
            DataTable t = new DataTable();
            publication.Fill(t);
            Publications.DataSource = t;
            Publications.DataBind();
            SqlDataAdapter studentlist1 = new SqlDataAdapter("ViewAllMyTheses", conn);
            studentlist1.SelectCommand.Parameters.AddWithValue("@ID", Session["user"]);
            studentlist1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable t1 = new DataTable();
            studentlist1.Fill(t1);
            allstudentthesis1.DataSource = t1;
            allstudentthesis1.DataBind();

        }
        protected void submitlinkpub(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand linkpub = new SqlCommand("linkPubThesis", conn);
            if (serialno.Text == "" ||
               pubid.Text == "")
            {
                Response.Write("Please fill all the spaces ");
            }
            else
            {
                int serialnum = Int16.Parse(serialno.Text);
                linkpub.Parameters.Add(new SqlParameter("@thesisSerialNo", serialnum));
                int pubid1 = Int16.Parse(pubid.Text);
                linkpub.Parameters.Add(new SqlParameter("@pubID", pubid1));
                linkpub.CommandType = CommandType.StoredProcedure;
                SqlParameter success = linkpub.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
                linkpub.CommandType = CommandType.StoredProcedure;
                success.Direction = ParameterDirection.Output;
                //ask is that how it should be linked only
                //check how to link to ongoing thesis
                conn.Open();
                linkpub.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "1")
                {
                    Response.Write("Successfully linked");
                }
                else
                {
                    Response.Write("UnSuccessful transaction, make sure the serial number and the publication id are correct");
                }
            }
        }
    }
}
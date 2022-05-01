using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Documents;

namespace GUCera
{
    public partial class AddProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitaddprog(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addprog = new SqlCommand("AddProgressReport", conn);
            
           
            if ( progdate.Text == "" ||
                serialno.Text == "" || reportno.Text == "")
            {
                Response.Write("Please fill all the spaces ");
            }
            else
            {   // id.Text.DefaultIfEmpty(); progdate.Text.DefaultIfEmpty();
               
                DateTime progdate1 = DateTime.Parse(progdate.Text);
                int serialno1 = Int16.Parse(serialno.Text);
                int repno = Int16.Parse(reportno.Text);
                addprog.Parameters.Add(new SqlParameter("@studentID ", Session["user"]));
                //ask how to do date
                //String pass = password.Text;
                addprog.Parameters.Add(new SqlParameter("@progressReportDate", progdate1));
                addprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialno1));
                addprog.Parameters.Add(new SqlParameter("@progressReportNo", repno));
                addprog.CommandType = CommandType.StoredProcedure;
                SqlParameter success = addprog.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
                success.Direction = ParameterDirection.Output;

                conn.Open();
                addprog.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "1") {
                    Response.Write("Successfully Added");
                        }
                else
                {
                    Response.Write("Unsuccessful transaction , please make sure the serial number you entered is of ongoing and existing thesis");
                }
            }
        }
    }
}
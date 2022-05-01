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
    public partial class FillProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            SqlDataAdapter ongoingthesis = new SqlDataAdapter("ViewAStudentProgressReports", conn);
            ongoingthesis.SelectCommand.Parameters.AddWithValue("@StudentID", Session["user"]);
            ongoingthesis.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable t = new DataTable();
            ongoingthesis.Fill(t);
            filltable.DataSource = t;
            filltable.DataBind();

        }
        protected void submitfillprog(object sender, EventArgs e)
        {
            //test this
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addprog = new SqlCommand("FillProgressReport", conn);
            if ( serialno.Text == "" ||
               reportno.Text == "" || state.Text == "" || description.Text == "")
            {
                Response.Write("Please fill all the spaces ");
            }
            else
            {
                
                addprog.Parameters.Add(new SqlParameter("@studentID ", Session["user"]));
                int serialno1 = Int16.Parse(serialno.Text);
                addprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialno1));
                int repno = Int16.Parse(reportno.Text);
                addprog.Parameters.Add(new SqlParameter("@progressReportNo", repno));
                int state1 = Int16.Parse(state.Text);
                addprog.Parameters.Add(new SqlParameter("@state", state1));
                addprog.Parameters.Add(new SqlParameter("@description ", description.Text));
                addprog.CommandType = CommandType.StoredProcedure;
                SqlParameter success = addprog.Parameters.Add(new SqlParameter("@success", SqlDbType.Int));
                success.Direction = ParameterDirection.Output;
                conn.Open();
                addprog.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "1")
                {
                    Response.Write("Successfully Filled");
                }
                else
                {
                    Response.Write("UnSuccessfully Transaction, please make sure you entered an existing report number of an ongoing thesis");
                }

            }
        }
    }
}
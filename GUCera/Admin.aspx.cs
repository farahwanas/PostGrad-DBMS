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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mainconn = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from supervisor";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            //sqlcomm.Parameters.AddWithValue("title", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            sqlconn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String mainconn = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();
            SqlCommand loginProc = new SqlCommand("AdminViewAllTheses", sqlconn);
            SqlCommand loginProc2 = new SqlCommand("AdminViewOnGoingTheses", sqlconn);
            loginProc2.CommandType = CommandType.StoredProcedure;

            SqlParameter count = loginProc2.Parameters.Add("@thesesCount", SqlDbType.Int);
            count.Direction = System.Data.ParameterDirection.Output;

            loginProc2.ExecuteNonQuery();
            Label countlabel = new Label();
            countlabel.Text = "Count of On Going Theses: " + count.Value.ToString();
            form1.Controls.Add(countlabel);

            loginProc.CommandType = CommandType.StoredProcedure;






            loginProc2.ExecuteNonQuery();


            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(loginProc);
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String mainconn = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection sqlconn = new SqlConnection(mainconn);

            String thesisno = ThesisNumber.Text;

            SqlCommand proc = new SqlCommand("AdminIssueThesisPayment", sqlconn);
            proc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesisno));
            proc.Parameters.Add(new SqlParameter("@amount", Amount.Text));
            proc.Parameters.Add(new SqlParameter("@noOfInstallments", noOfInstallments.Text));
            proc.Parameters.Add(new SqlParameter("@fundPercentage", FundPercentage.Text));
            SqlParameter success = proc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = System.Data.ParameterDirection.Output;
            proc.CommandType = CommandType.StoredProcedure;

            sqlconn.Open();
            proc.ExecuteNonQuery();
            sqlconn.Close();

            if (success.Value.ToString() == "1")
            {
                Label countlabel = new Label();
                countlabel.Text = "Thesis Payment Issued Successfully";
                form1.Controls.Add(countlabel);
            }
            else
            {
                Label countlabel = new Label();
                countlabel.Text = "Thesis Number Not Found";
                form1.Controls.Add(countlabel);
            }




        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String mainconn = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection sqlconn = new SqlConnection(mainconn);

            String paymentIDD = paymentID.Text;
            DateTime InstallStartDatee = DateTime.Parse(InstallStartDate.Text);


            SqlCommand proc = new SqlCommand("AdminIssueInstallPayment", sqlconn);
            proc.Parameters.Add(new SqlParameter("@paymentID", paymentIDD));
            proc.Parameters.Add(new SqlParameter("@InstallStartDate", InstallStartDatee));

            SqlParameter success = proc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = System.Data.ParameterDirection.Output;
            proc.CommandType = CommandType.StoredProcedure;

            sqlconn.Open();
            proc.ExecuteNonQuery();
            sqlconn.Close();

            if (success.Value.ToString() == "1")
            {
                Label countlabel = new Label();
                countlabel.Text = "Installments Issued Successfully";
                form1.Controls.Add(countlabel);
            }
            else
            {
                Label countlabel = new Label();
                countlabel.Text = "Payment Number Not Found";
                form1.Controls.Add(countlabel);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String mainconn = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection sqlconn = new SqlConnection(mainconn);

            String thesisno = TextBox4.Text;

            SqlCommand proc = new SqlCommand("AdminUpdateExtension", sqlconn);
            proc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesisno));
            SqlParameter success = proc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = System.Data.ParameterDirection.Output;
            proc.CommandType = CommandType.StoredProcedure;

            sqlconn.Open();
            proc.ExecuteNonQuery();
            sqlconn.Close();

            if (success.Value.ToString() == "1")
            {
                Label countlabel = new Label();
                countlabel.Text = "Number of extensions extended Successfully";
                form1.Controls.Add(countlabel);
            }
            else
            {
                Label countlabel = new Label();
                countlabel.Text = "Thesis Number Not Found";
                form1.Controls.Add(countlabel);
            }

        }

        /*CREATE Proc AdminIssueInstallPayment
@paymentID int,
@InstallStartDate date*/



    }
}
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
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void studentreg(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand gucianornot = new SqlCommand("checkifgucian", conn);
            gucianornot.Parameters.Add(new SqlParameter("@id", Session["user"]));

            SqlParameter gucianbit = gucianornot.Parameters.Add(new SqlParameter("@gucian", SqlDbType.Int));
            gucianornot.CommandType = CommandType.StoredProcedure;
            gucianbit.Direction = ParameterDirection.Output;
            conn.Open();
            gucianornot.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            SqlDataAdapter studentreg = new SqlDataAdapter("viewMyProfile", conn);
            studentreg.SelectCommand.Parameters.AddWithValue("@studentId", Session["user"]);
            studentreg.SelectCommand.CommandType = CommandType.StoredProcedure;
            //studentreg.Parameters.Add(new SqlParameter("@studentId", Session["user"]));
            DataTable t = new DataTable();
            studentreg.Fill(t);
            allstudentthesis.Visible = false;
            coursegradestable.Visible = false;
            if (gucianbit.Value.ToString() == "1")
            {
                GucStudentinfo.DataSource = t;
                GucStudentinfo.DataBind();
                GucStudentinfo.Visible = true;
            }
            else
            {
                NonGucStudentinfo.DataSource = t;
                NonGucStudentinfo.DataBind();
                NonGucStudentinfo.Visible = true;
            }
            // Response.Write("Successfully registered");
            conn.Close();
           

        }
        protected void studentlist(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            GucStudentinfo.Visible = false;
            NonGucStudentinfo.Visible = false;
            coursegradestable.Visible = false;
            SqlDataAdapter studentlist1 = new SqlDataAdapter("ViewAllMyTheses", conn);
            studentlist1.SelectCommand.Parameters.AddWithValue("@ID", Session["user"]);
            studentlist1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable t = new DataTable();
            studentlist1.Fill(t);
            allstudentthesis.DataSource = t;
            allstudentthesis.DataBind();
            allstudentthesis.Visible = true;
            conn.Close();



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addmobile = new SqlCommand("addMobile", conn);
            String x = Session["user"].ToString();
            addmobile.Parameters.Add(new SqlParameter("@ID", Session["user"].ToString()));

            String mob = phonenumbers.Text;

            addmobile.Parameters.Add(new SqlParameter("@mobile_number", mob));
            addmobile.CommandType = CommandType.StoredProcedure;
            conn.Open();
            addmobile.ExecuteNonQuery();
            conn.Close();
            Response.Write("Successful");

            // TextBox fff = new TextBox();
        }

        protected void nonguc_courses(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            GucStudentinfo.Visible = false;
            NonGucStudentinfo.Visible = false;
            allstudentthesis.Visible=false;
            //SqlCommand coursepayment = new SqlCommand("ViewCoursePaymentsInstall", conn);
            //coursepayment.Parameters.Add(new SqlParameter("@ID", Session["user"]));
            //SqlCommand coursepayment = new SqlCommand("ViewCoursesGrades", conn);
            //ask i changed f view courses grades
            SqlCommand gucianornot = new SqlCommand("checkifgucian", conn);
            gucianornot.Parameters.Add(new SqlParameter("@id", Session["user"]));

            SqlParameter gucianbit = gucianornot.Parameters.Add(new SqlParameter("@gucian", SqlDbType.Int));
            gucianornot.CommandType = CommandType.StoredProcedure;
            gucianbit.Direction = ParameterDirection.Output;
            conn.Open();
            gucianornot.ExecuteNonQuery();
            conn.Close();
            // Response.Write(gucianbit.Value.ToString());
            if (gucianbit.Value.ToString() == "1")
            {
                Response.Write("This feature is only for Non Gucians");
            }
            else
            {

                SqlCommand coursegrade = new SqlCommand("ViewCoursesGrades", conn);
                coursegrade.Parameters.Add(new SqlParameter("@studentID", Session["user"]));
                conn.Open();
                GucStudentinfo.Visible = false;
                NonGucStudentinfo.Visible = false;
                SqlDataAdapter coursegrade1 = new SqlDataAdapter("ViewCoursesGrades", conn);
                coursegrade1.SelectCommand.Parameters.AddWithValue("@studentID", Session["user"]);
                coursegrade1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable t = new DataTable();
                coursegrade1.Fill(t);
                coursegradestable.DataSource = t;
                coursegradestable.DataBind();
                coursegradestable.Visible = true;
                conn.Close();

            }
        }
       
        protected void addprogressreport(object sender, EventArgs e)
        {
            Response.Redirect("AddProgressReport.aspx");



        }
        protected void fillprogressreport(object sender, EventArgs e)
        {
            Response.Redirect("FillProgressReport.aspx");



        }
        protected void addpublication(object sender, EventArgs e)
        {
            Response.Redirect("AddPublication.aspx");



        }
        protected void linkpublication(object sender, EventArgs e)
        {
            Response.Redirect("LinkPublicationToThesis.aspx");

           

        }
    }
}
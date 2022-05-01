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
    public partial class Examiner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Edit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            
            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["user"];

            String namee = name.Text;
            String fieldOfWorkk = fieldOfWork.Text;

            SqlCommand loginProc = new SqlCommand("editexaminerProfile", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@id", id));
            loginProc.Parameters.Add(new SqlParameter("@name", namee));
            loginProc.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOfWorkk));

            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Int);
            sucess.Direction = System.Data.ParameterDirection.Output;


            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (sucess.Value.ToString() == "1")
            {
                Response.Write("edited successfully");

            }

            else
            {
                Response.Write("not edited successfully");
            }



        }



        protected void addgrade(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
           
            SqlConnection conn = new SqlConnection(connStr);


            DateTime DefenseDatee = DateTime.Parse(DefenseDategrade.Text);
            int ThesisSerialNumberr = Int16.Parse(ThesisSerialNumbergrade.Text);
            String gradee = grade.Text;

            SqlCommand loginProc = new SqlCommand("AddDefenseGrade", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNumberr));
            loginProc.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDatee));
            loginProc.Parameters.Add(new SqlParameter("@grade", gradee));


            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Int);
            sucess.Direction = System.Data.ParameterDirection.Output;


            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (sucess.Value.ToString() == "1")
            {
                Response.Write("grade added successfully");

            }

            else
            {
                Response.Write("grade not added successfully");
            }
        }

        protected void addcomment(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
         
            SqlConnection conn = new SqlConnection(connStr);


            DateTime DefenseDatee = DateTime.Parse(DefenseDate.Text);
            int ThesisSerialNumberr = Int16.Parse(ThesisSerialNumber.Text);
            String commentt = comment.Text;

            SqlCommand loginProc = new SqlCommand("AddCommentsGrade", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNumberr));
            loginProc.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDatee));
            loginProc.Parameters.Add(new SqlParameter("@comments", commentt));


            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Int);
            sucess.Direction = System.Data.ParameterDirection.Output;


            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (sucess.Value.ToString() == "1")
            {
                Response.Write("comment added successfully");

            }

            else
            {
                Response.Write("comment not added successfully");
            }
        }

        protected void search(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from thesis where title like '%'+@title+'%'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = conn;
            sqlcomm.Parameters.AddWithValue("title", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            searchGridView.DataSource = dt;
            searchGridView.DataBind();

            conn.Close();
        }

        protected void list(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            
            SqlConnection sqlconn = new SqlConnection(connStr);

            sqlconn.Open();
            SqlCommand loginProc = new SqlCommand("listAttended", sqlconn);
            int id = (int)Session["user"];

            loginProc.Parameters.Add(new SqlParameter("@examinerId", id));
            loginProc.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(loginProc);
            sda.Fill(dt);
            listGridView.DataSource = dt;
            listGridView.DataBind();



        }
    }
}
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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (username.Text == "" || password.Text == "") { 
                Response.Write("Please enter your username and password");
            }
            else
            {
                int id = Int16.Parse(username.Text);
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginproc.Parameters.Add(new SqlParameter("@success", SqlDbType. Int));
            SqlParameter type = loginproc.Parameters.Add(new SqlParameter("@type", SqlDbType.Int));
            loginproc.CommandType = CommandType.StoredProcedure;
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

        if (success.Value.ToString() == "1")
            {
                Session["user"] = id;
                if (type.Value.ToString() == "0")
                {

                    //Response.Red
                    Response.Redirect("Student.aspx");
                }
                else if (type.Value.ToString() == "1")
                {

                    //Response.Red
                    Response.Redirect("Admin.aspx");
                }
                else if (type.Value.ToString() == "2")
                {

                    //Response.Red
                    Response.Redirect("Supervisor.aspx");
                }
                else if (type.Value.ToString() == "3")
                {

                    Response.Redirect("Examiner.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }

        }
    }
}
                }
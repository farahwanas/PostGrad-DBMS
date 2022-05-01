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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (fname.Text == "" || lname.Text == "" ||
               password.Text == "" || faculty.Text == "" || email.Text == ""
               || address.Text == "")
            {
                Response.Write("Please fill all the spaces ");
            }
            else
            {
                String firstt = fname.Text;
                String last = lname.Text;
                String pass = password.Text;
                String fac = faculty.Text;
                String email1 = email.Text;
                String address1 = address.Text;
                int uniname = 0;

                SqlCommand studentreg = new SqlCommand("studentRegister", conn);
                studentreg.Parameters.Add(new SqlParameter("@first_name", firstt));
                studentreg.Parameters.Add(new SqlParameter("@last_name", last));
                studentreg.Parameters.Add(new SqlParameter("@password", pass));
                studentreg.Parameters.Add(new SqlParameter("@faculty", fac));
                studentreg.Parameters.Add(new SqlParameter("@email", email1));
                studentreg.Parameters.Add(new SqlParameter("@address", address1));

                if (DropDownList1.SelectedItem.Value == "1")
                {
                    uniname = 1;

                }
                if (DropDownList1.SelectedItem.Value == "2")
                {
                    uniname = 0;
                }
                studentreg.Parameters.Add(new SqlParameter("@Gucian", uniname));
                studentreg.CommandType = CommandType.StoredProcedure;
                //type.Direction = ParameterDirection.Output;

                conn.Open();
                studentreg.ExecuteNonQuery();
                conn.Close();

                //ask howa hena fi session user
                //Session["user"] = id;
                Response.Write("Successfully registered");

            }

        }
    }
}

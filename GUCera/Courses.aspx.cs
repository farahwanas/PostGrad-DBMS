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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //SqlConnection conn = new SqlConnection(connStr);

            //SqlCommand courses = new SqlCommand("AdminListNonGucianCourse", conn);
            //courses.CommandType = CommandType.StoredProcedure;

            //conn.Open();
            //SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            //while (rdr.Read())
            //{
            //    String courseName = rdr.GetString(rdr.GetOrdinal("code"));
            //    Label name = new Label();
            //    name.Text = courseName;
            //    form1.Controls.Add(name);
            //}
            //conn.Close();

            Response.Write(Session["user"]);
        }
    }
}
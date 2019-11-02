using System.Data;
using System.Data.SqlClient;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Project.Models;
using System.Text;

namespace Project.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }

            /* If session is active then redirect to profile instead of login page */
            string svar = Convert.ToString(Session["id"]);
            if (!svar.Equals(""))
            {
                Response.Redirect("/Profile");
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string eid = EmployeeId.Text;
                string pass = Password.Text;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
                con.Open();
                string qry = "select * from Employee where EmployeeId='" + eid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["id"] = EmployeeId.Text;
                    Response.Redirect("/Profile");
                }
                else
                {
                    sb.Append(@"
                         <div class='alert alert-dismissible alert-danger'>
                         <button type='button' class='close' data-dismiss='alert'>&times;</button>
                         <strong>Oh snap!</strong> Employee doesn't exist. </div>");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                sb.Append(@"
                         <div class='alert alert-dismissible alert-warning'>
                         <button type='button' class='close' data-dismiss='alert'>&times;</button>
                         <strong>Warning!</strong>" + ex.Message + "</div>");
            }
            PlaceHolder1.Controls.Add(new LiteralControl { Text = sb.ToString() });
        }
    }
}
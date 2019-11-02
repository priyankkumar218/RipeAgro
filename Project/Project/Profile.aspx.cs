using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Project
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Display a success banner using the template css */
            StringBuilder sb = new StringBuilder();
            sb.Append(@"
                        <div class='alert alert-dismissible alert-success'>
                        <button type='button' class='close' data-dismiss='alert'>&times;</button>
                        <strong>Welcome Back!</strong>.</div>");

            /* Check if session is active then stay on profile else redirect to login */
            if (!Convert.ToString(Session["id"]).Equals(""))
                Label1.Text = "Welcome, " + Session["id"].ToString();
            else
                Response.Redirect("/Account/Login");
            
            /* Start of try block */
            try
            {
                /* Start of Connectivity */
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
                con.Open();
                string qry = @"select Name, Gender, Designation, Department 
                         from Employee where 
                         EmployeeId='" + Session["id"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label2.Text = "Name: " + rdr["Name"].ToString();
                    Label3.Text = "Gender: " + rdr["Gender"].ToString();
                    Label4.Text = "Designation: " + rdr["Designation"].ToString();
                    Label5.Text = "Department: " + rdr["Department"].ToString();
                }

                /* Close the connection */
                con.Close();
            }
            catch (Exception ex)
            {
                sb.Append(@"
                         <div class='alert alert-dismissible alert-warning'>
                         <button type='button' class='close' data-dismiss='alert'>&times;</button>
                         <strong>Warning!</strong>" + ex.Message + "</div>");
            }

            /* Set the contents of sb code on placeholder */
            PlaceHolder1.Controls.Add(new LiteralControl { Text = sb.ToString() });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* Logout and clear the session*/
            Session.RemoveAll();
            Response.Redirect("/Account/Login");  
        }
    }
}
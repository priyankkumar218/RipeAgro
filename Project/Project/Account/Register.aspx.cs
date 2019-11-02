using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using Project.Models;

namespace Project.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string svar = Convert.ToString(Session["id"]);
            if (!svar.Equals(""))
            {
                Response.Redirect("/Profile");
            }
        }
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            String gender = string.Empty;
            if (Male.Checked)
                gender = "Male";
            else if (Female.Checked)
                gender = "Female";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"INSERT INTO Employee(EmployeeId, Name, Password, Gender, Designation, Department)
                                               VALUES ('" + EmployeeId.Text + "', '" + FullName.Text + "', '" + ConfirmPassword.Text + "', '" + Designation.Text + "', '"+ gender +"', '" + DropDownList1.SelectedValue + "')", con);
            comm.ExecuteNonQuery();
            sb.Append(@"
            <div class='alert alert-dismissible alert-success'>
                         <button type='button' class='close' data-dismiss='alert'>&times;</button>
                         <strong>Well done!</strong> You have successfully registered. 
                         Click <a href='/Account/Login' class='alert-link'>here</a> to login.</div>");
            PlaceHolder1.Controls.Add(new LiteralControl { Text = sb.ToString() });
            EmployeeId.Text = "";
            FullName.Text = "";
            ConfirmPassword.Text = "";
            Designation.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            DropDownList1.SelectedIndex = 0;
            con.Close();
        }
    }
}
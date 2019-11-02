using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Project
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(@"Insert into Contact
                            (ContactName, ContactEmail, Query) VALUES
                            ('" + YourName.Text + "', '" + YourEmail.Text +"', '" + QueryArea.Text +"')", con);
            com.ExecuteNonQuery();
            YourName.Text = "";
            YourEmail.Text = "";
            QueryArea.Text = "";
            sb.Append(@"<table class='table table-striped table-hover'>
                            <tr class='success'>
                                <td colspan=2>
                                    <p class = 'lead'>
                                        Thank you for contacting us. We will get back to you within 2-3 working days.
                                    </p>
                                </td>
                            </tr>
                        </table>");
            PlaceHolder1.Controls.Add(new Literal { Text = sb.ToString() });
            con.Close();
        }
    }
}
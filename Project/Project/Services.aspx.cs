using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Project
{
    public partial class Services : System.Web.UI.Page
    {
        StringBuilder services = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand("Select * from ServicesImages", con);
                SqlDataReader rdr = comm.ExecuteReader();
                /* Start of Services Body */
                if (rdr.HasRows)
                {
                     services.Append(@"<style>
                        h3 {
                            font-family: 'Arial Rounded MT Bold'; 
                            text-decoration: underline overline; 
                            color: #008000
                        }
                        </style>");
                    services.Append("<table class='table table-striped table-hover'>");
                    services.Append("<tbody>");
                     while (rdr.Read())
                     {
                         services.Append("<tr>");
                         services.Append("<td><h4>" + rdr[1] + "</h4></td>");
                         services.Append(@"<td><p class='lead'>"+ rdr[2] + "</p></td>");
                         services.Append("</tr>");
                     }
                     services.Append(@"<tr class='warning'>
                                        <td colspan=2>
                                        <p class = 'lead'>
                                            Interested in our services? <a href='/Contact'>Contact Us</a>
                                        </p>
                                        </td>
                                      </tr>");
                     services.Append("</tbody>");
                     services.Append("</table>");
                }

                /* Set the services to placeholder */
                PlaceHolder1.Controls.Add(new Literal { Text = services.ToString() });

                con.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    public partial class Events : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand("Select * from Events", con);
                SqlDataReader rdr = comm.ExecuteReader();
                table.Append("<table class='table table-striped table-hover'>");
                /* Table Head Definition */
                table.Append(@"<thead>
                            <tr class='success'>
                            <th>Event ID</th>
                            <th>Event Name</th>
                            <th>Description</th>
                            <th>Date</th>
                            <th>Contact</th>
                            </tr>
                            </thead>");

                /* Start of Table Body */
                table.Append("<tbody>");
                if(rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        table.Append("<tr class='warning'>");
                        table.Append("<td>"+rdr[0]+"</td>");
                        table.Append("<td>"+rdr[1]+"</td>");
                        table.Append("<td>"+rdr[2]+"</td>");
                        table.Append("<td>"+rdr[3]+"</td>");
                        table.Append("<td>" + rdr[4] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</tbody>");
                table.Append("</table>");

                /* Set the table to placeholder */
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

                con.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class ViewStock : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToString(Session["id"]).Equals(""))
            {
                if (!Page.IsPostBack)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=ProjectDW;Integrated Security=True");
                    con.Open();
                    SqlCommand comm = new SqlCommand("Select * from Manufacture_Inventory", con);
                    SqlDataReader rdr = comm.ExecuteReader();
                    table.Append("<table class='table table-striped table-hover'>");
                    /* Table Head Definition */
                    table.Append(@"<thead>
                              <tr class='success'>
                              <th>Product ID</th>
                              <th>Product Name</th>
                              <th>Product Price</th>
                              <th>Available Stock</th>
                              </tr>
                              </thead>");

                    /* Start of Table Body */
                    table.Append("<tbody>");
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            table.Append("<tr class='warning'>");
                            table.Append("<td>" + rdr[0] + "</td>");
                            table.Append("<td>" + rdr[1] + "</td>");
                            table.Append("<td>" + rdr[2] + "</td>");
                            table.Append("<td>" + rdr[3] + "</td>");
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
            else
            {
                Response.Redirect("/Account/Login");
            }
        }
    }
}
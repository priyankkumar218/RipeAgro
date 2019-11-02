using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class About : Page
    {
        StringBuilder about = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5455OK;Initial Catalog=RipeAgro;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand("Select * from AboutUs", con);
                SqlDataReader rdr = comm.ExecuteReader();
                /* Start of About Body */
                if (rdr.HasRows)
                {
                    about.Append(@"<style>
                        h2 {
                            font-family: 'Arial Rounded MT Bold'; 
                            text-decoration: underline overline; 
                            color: #008000
                        }
                    </style>");
                    while (rdr.Read())
                    {
                        about.Append(@"<h2>" + rdr[1] + "</h2>");
                        about.Append("<p>" + rdr[2] + "</p>");
                        about.Append("<br/>");
                    }
                }

                /* Set the about to placeholder */
                PlaceHolder1.Controls.Add(new Literal { Text = about.ToString() });

                con.Close();
            }
        }
    }
}
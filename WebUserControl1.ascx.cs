using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1P21P2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string vv = RadioButtonList1.SelectedValue;
            int ivv = Convert.ToInt32(vv);
            SqlConnection connect = new SqlConnection("data source =DESKTOP-6GNKJL5\\SQLEXPRESS01; database =Tasks; integrated security=SSPI");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select number from votings where id='" + ivv + "'", connect);
            SqlDataReader sdd = cmd.ExecuteReader();
            sdd.Read();
            string vvr = Convert.ToString(sdd[0]);
            Session["num"] = vvr;
            Session["iid"] = ivv;

            connect.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("voting");
                cook.Values.Add("vote", Convert.ToString(RadioButtonList1.SelectedItem));
                cook.Values.Add("state", "true");

           
            /////////////////////////
            cook.Expires = DateTime.Now.AddDays(100);

            Response.Cookies.Add(cook);
            //////////////////////////////
            string vv = RadioButtonList1.SelectedValue;
            int ivv = Convert.ToInt32(vv);
            SqlConnection connect1 = new SqlConnection("data source =DESKTOP-6GNKJL5\\SQLEXPRESS01; database =Tasks; integrated security=SSPI");
            connect1.Open();
            string vvv = Convert.ToString(Session["num"]);
            int ivvr = Convert.ToInt32(vvv);
            ivvr++;

            SqlCommand ccc = new SqlCommand("Update votings set number='" + ivvr + "' where id='" + ivv + "'", connect1);
            ccc.ExecuteNonQuery();
            connect1.Close();


        }
    }
}
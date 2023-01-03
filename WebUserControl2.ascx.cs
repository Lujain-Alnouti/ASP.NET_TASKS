using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1P21P2
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("data source =DESKTOP-6GNKJL5\\SQLEXPRESS01; database =Tasks; integrated security=SSPI");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from votings", connect);
            SqlDataReader sdd = cmd.ExecuteReader();
            while (sdd.Read())
            {
                if (Convert.ToInt32(sdd[0])==1) {
                    Session["Exn"] = Convert.ToInt32(sdd[2]);
                }
                else if (Convert.ToInt32(sdd[0]) == 2)
                {
                    Session["Vgn"] = Convert.ToInt32(sdd[2]);
                }
                else if (Convert.ToInt32(sdd[0]) == 3)
                {
                    Session["Gn"] = Convert.ToInt32(sdd[2]);
                }
                else if (Convert.ToInt32(sdd[0]) == 4)
                {
                    Session["Pn"] = Convert.ToInt32(sdd[2]);
                }

            }
           
            connect.Close();

            double ee = Convert.ToInt32(Session["Exn"]);
            double vgvg = Convert.ToInt32(Session["Vgn"]);
            double gg = Convert.ToInt32(Session["Gn"]);
            double pp = Convert.ToInt32(Session["Pn"]);
            double tot = ee + vgvg + gg + pp;
            Session["total"] = Convert.ToString(tot);


            ///////////////////////////
            double xxe = (ee / tot);
            int exavg = Convert.ToInt32(xxe * 100);
            exp.Width = exavg + '%';
            exp.Text = Convert.ToString(exavg) + '%';
            //////
            double xxv = (vgvg / tot);
            int vavg = Convert.ToInt32(xxv * 100);
            vgp.Width = vavg + '%';
            vgp.Text = Convert.ToString(vavg) + '%';
            //////
            double xxg = (gg / tot);
            int gavg = Convert.ToInt32(xxg * 100);
            gp.Width = gavg + '%';
            gp.Text = Convert.ToString(gavg) + '%';
            //////
            double xxp = (pp / tot);
            int pavg = Convert.ToInt32(xxp * 100);
            ppp.Width = pavg + '%';
            ppp.Text = Convert.ToString(pavg) + '%';




        }


    }
}
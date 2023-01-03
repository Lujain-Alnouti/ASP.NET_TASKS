using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1P21P2
{
    public partial class task1P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["voting"] != null)
            {
                if (Request.Cookies["voting"]["state"] == "true")
                {
                    WebUserControl1.Visible = false;
                    WebUserControl2.Visible = true;
                }
                else
                {
                    WebUserControl1.Visible = true;
                    WebUserControl2.Visible = false;
                }
            }
        }

    }
}
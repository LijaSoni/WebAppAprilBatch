using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAprilBatch
{
    public partial class P3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application["uid"].ToString();
            Label2.Text = Session["upwd"].ToString();
        }
    }
}
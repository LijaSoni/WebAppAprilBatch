using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAprilBatch
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = TextBox1.Text +" "+TextBox2.Text;
        }
    }
}
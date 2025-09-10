using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAprilBatch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            int x, y,s;
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            s = x + y;
            Label1.Text = Convert.ToString(s);
            Label1.Text = s.ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = (Convert.ToInt32(TextBox1.Text)- Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = (Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}
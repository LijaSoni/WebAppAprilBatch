using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAprilBatch
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;//get full path of file
            FileUpload1.SaveAs(MapPath(p));//save

            Panel1.Visible = true;
            Label1.Text = p;
            Image1.ImageUrl = p;
        }
    }
}
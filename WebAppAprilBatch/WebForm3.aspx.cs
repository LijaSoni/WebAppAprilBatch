using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAprilBatch
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = RadioButtonList1.SelectedItem.Text;
            Label4.Text = RadioButtonList1.SelectedItem.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label5.Text = ListBox1.SelectedItem.Text;
            Label6.Text = ListBox1.SelectedItem.Value;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //string s = "";
            //for (int i = 0; i < CheckBoxList1.Items.Count; i++)//index
            //{
            //    if (CheckBoxList1.Items[i].Selected)
            //    {
            //        s = s + CheckBoxList1.Items[i].Text + ",";
            //    }
            //}
            //Label7.Text = s;




            string s1 = "";
            foreach (ListItem  item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    s1 = s1 + item.Text + ",";
                }
            }
            Label7.Text = s1;

        }
    }
}
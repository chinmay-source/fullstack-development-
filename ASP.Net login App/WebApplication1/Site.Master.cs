using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            LabelCounter.Text = "Your Visiter No:" + Application["Counter"].ToString();

            if (Session["userID"] == null)
            {
                ButtonLogout.Visible = false;
            }
            else
            {
                ButtonLogout.Visible = true;
            }

            AdminSettings Settings = (AdminSettings)Application["Settings"];
            try
            {
                LabelHeaderText.Text = Settings.headerText;
                LabelFooterText.Text = Settings.footerText;
            }
            catch (Exception)
            {

            }

        }
    
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");

    }
    protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("userID");
            Response.Redirect("Default.aspx");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public partial class AdminControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
             {
                AdminSettings Settings = (AdminSettings)Application["Settings"];
                TextBoxdefaultText1.Text = Settings.DefaultPageText1;

                TextBoxdefaultText2.Text = Settings.DefaultPageText2;
                TextBoxHeader.Text = Settings.headerText;
                TextBoxFooter.Text = Settings.footerText;

             }
           


        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            AdminSettings Settings = (AdminSettings)Application["Settings"];
            Settings.DefaultPageText1 = TextBoxdefaultText1.Text;
            Settings.DefaultPageText2 = TextBoxdefaultText2.Text;
            Settings.headerText = TextBoxHeader.Text;
            Settings.footerText = TextBoxFooter.Text;
            webappManager.SaveSetting(Server.MapPath("~/App_Start/Settings.xml"),Settings);
            Application["Settings"] = Settings;

        }
    }
}
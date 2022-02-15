using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string userName = WebConfigurationManager.AppSettings["PFUserName"];
            string password = WebConfigurationManager.AppSettings["PFPassword"];

            if(TextBoxUserName.Text==userName && TextBoxPassword.Text == password)
            {
                Session.Add("userID",userName);
                
                Response.Redirect("AdminControlPanel.aspx");


            }
            else
            {
                LabelMessage.Text="please enter valid user name and password";
            }

        }
    }
}
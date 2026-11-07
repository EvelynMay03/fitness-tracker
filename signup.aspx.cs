using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDOCP_MMM
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            String name, psw, confirmPsw;
            name = username.Value;
            psw = password.Value;
            confirmPsw = confirm.Value;

            if (psw.Equals(confirmPsw))
            {
                bool ans = database.signup(name, psw);
                if (ans == true)
                {
                    output.Text = "Account Registered Successfully!";
                    
               
                }
                else
                {
                    output.Text = " Registetation Unsuccess!";
                }
            }

            else
            {
                output.Text = "Password Unmatch!";
            }
        }
    }
}
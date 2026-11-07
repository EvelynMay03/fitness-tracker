using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace DDOCP_MMM
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string name, psw;
            name = username.Value;
            psw = password.Value;
            int memberid = database.Login(name, psw);
            if (memberid == -1)
            {

                output.Text = " Try Again!";
                int count = dataManager.getFailCount();
                count++;
                if (count == 3)
                {
                    output.Text = "Failed 3 times! Try again after 15s";
                    Thread.Sleep(15000);
                    dataManager.setFailCount(0);
                }
                
                else
                {
                    dataManager.setFailCount(count);
                }
            }
            else
            {
                output.Text = "Successfully Login!";
                dataManager.setUserId(memberid);
                
                Response.Write("<script>location.assign('goals.aspx');</script>");
            }


        }
    }
}
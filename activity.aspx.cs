using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDOCP_MMM
{
    public partial class activity1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (dataManager.getUserId() == -1)
            {
                Response.Write("<script> location.assign('login.aspx'); </script>");
            }
        }
        protected void btnactivity_Click(object sender, EventArgs e)
        {

            int m1v, m2v, m3v;
            m1v = Convert.ToInt16(m1.Value);
            m2v = Convert.ToInt16(m2.Value);
            m3v = Convert.ToInt16(m3.Value);

            List<MetinAct> arr = dataManager.getMetinActId();

            bool ans1 = database.setActivity(dataManager.getUserId(), arr[0].getMetActId(), m1v);
            bool ans2 = database.setActivity(dataManager.getUserId(), arr[1].getMetActId(), m2v);
            bool ans3 = database.setActivity(dataManager.getUserId(), arr[2].getMetActId(), m3v);

            if (ans1 == true && ans2 == true && ans3 == true)
            {
                output.Text = "Metrics for activity are successfully inserted!";

            }
            else
            {
                output.Text = " Metrics for activity insertion failed!";
            }
        }
    }
}
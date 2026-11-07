using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDOCP_MMM
{
    public partial class goals : System.Web.UI.Page
    {
        protected List<Goals> goalslist;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (dataManager.getUserId() == -1)
            {
                Response.Write("<script> location.assign('login.aspx'); </script>");
            }

            if (!IsPostBack)
            {
                LoadGoals();
            }
        }
        protected void btngoal_Click(object sender, EventArgs e)
        {
            int cal = Convert.ToInt16(goalc.Value);
            bool ans = database.insertGoal(dataManager.getUserId(), cal);
            if (ans == false)
            {
                output.Text = "Try Again!";
            }
            else
            {
                output.Text = "Your Goal for Today is Successfully inserted! ";
            }

            LoadGoals();

        }

        private void LoadGoals()
        {
            goalslist = database.getGoals(dataManager.getUserId());
         
        }
    }
}
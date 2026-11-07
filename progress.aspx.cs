using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDOCP_MMM
{
    public partial class progress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (dataManager.getUserId() == -1)
            {
                Response.Write("<script> location.assign('login.aspx'); </script>");
            }

            if (!IsPostBack)
            {

                int userId = dataManager.getUserId();
                List<ActCalProgess> progressList = database.getActCalProgess(userId);


                DisplayProgress(progressList);
            }
        }
        private void DisplayProgress(List<ActCalProgess> progressList)
        {
            double totalCalories = 0;

            Console.WriteLine("ActivityId: {progress.getActivityId()}, CaloriesBurned: {progress.getCaloriesBurned()}");

            foreach (var progress in progressList)
            {
                switch (progress.getActId())
                {
                    case 1: // Walking
                        walkingCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                    case 2: // Swimming
                        swimmingCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                    case 3: // Pilates
                        pilatesCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                    case 4: // Badminton
                        badmintonCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                    case 5: // Golf
                        golfCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                    case 6: // Running
                        runningCalories.InnerText = progress.getCaloriesBurned().ToString();
                        totalCalories += progress.getCaloriesBurned();
                        break;
                }
            }

            Console.WriteLine("Total Calories: {totalCalories}");
            todayCalories.InnerText = totalCalories.ToString();
        }
    }
}
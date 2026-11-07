using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class ActCalProgess
    {
        public int ActId;
        public double CaloriesBurned;

        public ActCalProgess(int aid, double c)
        {

            ActId = aid;
            CaloriesBurned = c;


        }

        public void setActId(int id)
        {
            ActId = id;
        }
        public int getActId()
        {
            return ActId;
        }

        public void setCaloriesBurned(double c)
        {
            CaloriesBurned = c;
        }
        public double getCaloriesBurned()
        {
            return CaloriesBurned;
        }
    }
}
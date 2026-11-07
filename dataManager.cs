using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class dataManager
    {
        private static int userId = -1;
        private static List<MetinAct> metarr;
        private static int failCount = 0;

        public static void setUserId(int id)
        {
            userId = id;
        }
        public static int getUserId()
        {
            return userId;
        }
        public static void setMetinActId(List<MetinAct> list)
        {
            metarr = list;
        }
        public static List<MetinAct> getMetinActId()
        {
            return metarr;
        }
        

        public static void setFailCount(int c)
        {
            failCount = c;
        }
        public static int getFailCount()
        {
            return failCount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class MetinAct
    {
        private int metactid;
        private string metname;

        public MetinAct(int id, string name)
        {
            metactid = id;
            metname = name;
        }

        public void setMetActId(int id)
        {
            metactid = id;
        }
        public int getMetActId()
        {
            return metactid;
        }

        public void setMetName(string name)
        {
            metname = name;
        }
        public string getMetName()
        {
            return metname;
        }
    }
}
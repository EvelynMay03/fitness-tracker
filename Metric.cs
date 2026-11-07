using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class Metric
    {
        private int id;
        private string name;
        public Metric(int i, string n)
        {
            this.id = i;
            this.name = n;
        }
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
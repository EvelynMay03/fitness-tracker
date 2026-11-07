using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class MemActMetric
    {
        private int id, memberId, actMetricId, calorie;


        public MemActMetric(int i, int m, int am, int c)
        {
            this.id = i;
            this.memberId = m;
            this.calorie = c;
            this.actMetricId = am;
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
        public int MemberId
        {
            set
            {
                memberId = value;
            }
            get
            {
                return memberId;
            }
        }
        public int Calorie
        {
            set
            {
                calorie = value;
            }
            get
            {
                return calorie;
            }
        }
        public int ActMetricId
        {
            set
            {
                actMetricId = value;
            }
            get
            {
                return actMetricId;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class actMetric
    {
        private int id, activityId, metricId, calorie;
        private float MET;

        public actMetric(int i, int a, int m, int c, float met)
        {
            this.id = i;
            this.activityId = a;
            this.metricId = m;
            this.calorie = c;
            this.MET = met;
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
        public int MetricId
        {
            set
            {
                metricId = value;
            }
            get
            {
                return metricId;
            }
        }
        public int ActivityId
        {
            set
            {
                activityId = value;
            }
            get
            {
                return activityId;
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
        public float met
        {
            set
            {
                MET = value;
            }
            get
            {
                return MET;
            }
        }
    }
}
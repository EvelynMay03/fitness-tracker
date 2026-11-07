using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class Goals
    {
        private int id, memberId, calorie;
        private DateTime goalDate;

        public Goals(int i, int m, int c, DateTime d)
        {
            this.id = i;
            this.memberId = m;
            this.calorie = c;
            this.goalDate = d;
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
        public DateTime GoalDate
        {
            set
            {
                goalDate = value;
            }
            get
            {
                return goalDate;
            }
        }
    }
}
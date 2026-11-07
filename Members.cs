using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDOCP_MMM
{
    public class Members
    {
        private int id;
        private string name, password;
        private DateTime dateRegistered;

        public Members(int i, string n, string p, DateTime d)
        {
            this.id = i;
            this.name = n;
            this.password = p;
            this.dateRegistered = d;

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

        public string Password
        {

            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public DateTime DateRegistered
        {
            set
            {
                dateRegistered = value;
            }
            get
            {
                return dateRegistered;
            }
        }
    }
}
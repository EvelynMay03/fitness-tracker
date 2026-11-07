using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DDOCP_MMM
{
    public class database
    {
        private static SqlConnection join;

        public static bool click()
        {
            try
            {
                join = new SqlConnection(
    @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\betterHealth.mdf;Integrated Security=True"
);
                join.Open();
                return true;
            }
             catch
            {
                return false;
            }
        }

        public static bool close()
        {
             try
            {
                join.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool signup(string name, string password)
        {
            try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "Insert into Members(name,password,dateRegistered) values(@un,@p,GETDATE())";
                act.Parameters.AddWithValue("@un", name);
                act.Parameters.AddWithValue("@p", password);
                act.ExecuteNonQuery();
                int line = act.ExecuteNonQuery();
                close();
                return line > 0;

            }
            catch
            {
                return false;
            }
        }

        public static int Login(string name, string psw)
        {
            try
            {
                int id = -1;
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "select Id from Members where name=@un and password=@p";
                act.Parameters.AddWithValue("@un", name);
                act.Parameters.AddWithValue("@p", psw);
                SqlDataReader reader = act.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt16(reader["Id"]);

                }
                return id;

            }
            catch
            {
                return -1;
            }

        }

        public static bool insertGoal(int uid, int cal)
        {
             try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "insert into Goals(memberId, GoalDate, calorie) values(@m,GETDATE(),@c)";
                act.Parameters.AddWithValue("@m", uid);
                act.Parameters.AddWithValue("@c", cal);
                int line = act.ExecuteNonQuery();
                close();
                return line > 0;
            }
              catch
            {
                return false;
            }
        }
        public static double getCaloriesLog(int uid, DateTime date)
        {
            double totalCal = 0;

                try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = " SELECT SUM(am.MET * mam.unit) AS TotalCalories FROM actMetric AS am INNER JOIN MemActMetric AS mam ON am.Id = mam.actMetricId  WHERE mam.MemberId = @uid AND CAST(mam.Date AS DATE)=@d ";
                act.Parameters.AddWithValue("@uid", uid);
                act.Parameters.AddWithValue("@d", date.Date);
                var result = act.ExecuteScalar();

              
                if (result == DBNull.Value || result == null)
                {
                    totalCal = 0;
                   
                }
                else
                {
                    totalCal= Convert.ToDouble(result);
                }

                close(); 
                return totalCal;

            }
              catch
            {
                return 0;
            }
          
        }

        public static List<Goals> getGoals(int uid)
        {
            List<Goals> arr = new List<Goals>();

                try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "Select * from Goals where MemberId=@uid";
                act.Parameters.AddWithValue("@uid", uid);
                SqlDataReader reader = act.ExecuteReader();
                while (reader.Read())
                {
                    int i = Convert.ToInt16(reader["Id"].ToString());
                    int m = Convert.ToInt16(reader["MemberId"].ToString());
                    DateTime d = Convert.ToDateTime(reader["GoalDate"].ToString());
                    int c = Convert.ToInt16(reader["calorie"].ToString());
                    Goals goal = new Goals(i, m, c, d);
                    arr.Add(goal);


                }
                close();
                return arr;

            }
              catch
            {
                return arr;
            }
        }


        public static List<Activity> getActivity()
        {
            List<Activity> actArr = new List<Activity>();
            try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "select * from Activity ";
                SqlDataReader reader = act.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt16(reader["Id"].ToString());
                    string name = reader["name"].ToString();
                    Activity a = new Activity(id, name);
                    actArr.Add(a);
                }
                close();
                return actArr;



            }
            catch
            {
                return actArr;
            }
        }

        public static List<MetinAct> getMetinAct(int actid)
        {
            List<MetinAct> metarr = new List<MetinAct>();
            try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "select am.Id, m.name from actMetric am join Metric m on am.MetricId = m.Id  where am.ActivityId= @aid";
                act.Parameters.AddWithValue("@aid", actid);
                SqlDataReader reader = act.ExecuteReader();
                while (reader.Read())
                {
                    int Actmetid = Convert.ToInt16(reader["Id"].ToString());
                    string metname = reader["name"].ToString();

                    MetinAct metA = new MetinAct(Actmetid, metname);
                    metarr.Add(metA);

                }
                close();

            }
            catch
            {

            }
            return metarr;
        }

        public static bool setActivity(int uid, int actmetid, int amt)
        {
              try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                act.CommandText = "Insert into MemActMetric (MemberId, actMetricId, unit, Date) values (@uid,@actmetid, @amt, GETDATE())";
                act.Parameters.AddWithValue("@uid", uid);
                act.Parameters.AddWithValue("@actmetid", actmetid);
                act.Parameters.AddWithValue("@amt", amt);
                int line = act.ExecuteNonQuery();
                close();
                return line > 0;


            }
               catch
            {
                return false;
            }
        }

        public static List<ActCalProgess> getActCalProgess(int uid)
        {
            List<ActCalProgess> progressList = new List<ActCalProgess>();
            try
            {
                click();
                SqlCommand act = new SqlCommand();
                act.Connection = join;
                //  act.CommandText = " Select am.ActivityId, sum(am.MET* mam.unit) as BurnedCalories from MemActMetric mam ,actMetric am where am.Id = mam.actMetricId and mam.MemberId = @uid and CAST(Date as DATE) = CAST(GETDATE())  Group by ActivityId ";//
                act.CommandText = " SELECT am.ActivityId, SUM(am.MET * mam.unit) AS BurnedCalories FROM actMetric AS am INNER JOIN MemActMetric AS mam ON am.Id = mam.actMetricId WHERE mam.MemberId = @uid AND CAST(mam.Date AS DATE) = CAST(GETDATE() AS DATE) GROUP BY am.ActivityId";
                act.Parameters.AddWithValue("@uid", uid);


                SqlDataReader reader = act.ExecuteReader();
                while (reader.Read())
                {
                    int actId = Convert.ToInt16(reader["ActivityId"].ToString());
                    double calburned = Convert.ToDouble(reader["BurnedCalories"].ToString());


                    ActCalProgess progress = new ActCalProgess(actId, calburned);
                    progressList.Add(progress);
                }
                close();



            }
            catch
            {

            }
            return progressList;
        }
       
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="activity.aspx.cs" Inherits="DDOCP_MMM.activity1" %>
<%@ Import Namespace ="DDOCP_MMM" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Dashboard</title>
        <link rel="stylesheet" href="dashboard.css">
        <script src="https://kit.fontawesome.com/4899ddefbc.js" crossorigin="anonymous"></script>
    </head>
    <body>
    <header >
         <div class="dashboard" >
            <div class="logo">
                <div >
                    <i class="fa-solid fa-dumbbell"></i>
                </div>
                <div >
                    <p>Better Health Fitness Tracker</p>
                </div>
                
            </div>
            <nav class="switch">
              <a href="activity.aspx" class="active" >Activities</a>
              <a href="progress.aspx"  >  Progresses</a>
              <a href="goals.aspx"  >Goals</a>
          </nav>
        </div>
     </header>
    
          <main>
         
             <form id="setactivity" runat="server">
               <nav class="activities">
             
                <%
                    List<Activity> actArr = database.getActivity();
                    for (int i = 0; i < actArr.Count; i++)
                    {
                        %> 
                        <a href="activity.aspx?actid=<% =actArr[i].Id  %>"> <% =actArr[i].Name %>   </a>

                <%
                                            
                    }
                    
                %>
                </nav> 

               
                 <asp:Label ID="output" runat="server" Text=""></asp:Label> 
                <div class="activity-card">

                     <div class="headline">

                        <h3>Set your metric for Today's Activity! </h3>
                      <%
                      
                          string m1 = "metric1", m2 = "metric2", m3 = "metric3";
                                            
                          if (Request.QueryString["actid"] != null)
                          {
                              int aId = Convert.ToInt16(Request.QueryString["actid"]);
                          
                               if (aId == 1)
                              {
                                 %> <i class="fa-solid fa-person-walking"></i> <%
                              }
                               else if (aId == 2)
                              {
                                  %> <i class="fa-solid fa-person-swimming"></i> <%
                              }
                              else if (aId == 3)
                              {
                                  %>  <i class="fa-solid fa-people-roof"></i> <%
                              }
                               else if (aId == 4)
                              {
                                  %> <i class="fa-solid fa-table-tennis-paddle-ball"></i> <%
                              }
                               else if (aId == 5)
                              {
                                  %> <i class="fa-solid fa-golf-ball-tee"></i> <%
                              }
                               else if (aId == 6)
                              {
                                  %> <i class="fa-solid fa-person-running"></i> <%
                              }
                              %>
                           <%
                          List<MetinAct> metarr = database.getMetinAct(aId);
                          dataManager.setMetinActId(metarr);
                          if (metarr.Count > 0)
                          {
                              m1 = metarr[0].getMetName();
                              m2 = metarr[1].getMetName();
                              m3 = metarr[2].getMetName();
                          }
                         
                      }
                      
                %>
                    </div>
                      <div class="metrics">
                          <div class="metric">
                            <label for="m1"> <%=m1 %> </label>
                            <input type="number" id="m1" runat="server" required>
                          </div>
                          <div class="metric">
                            <label for="m2g"> <%=m2 %> </label>
                            <input type="number" id="m2" runat="server" required >
                          </div>
                          <div class="metric">
                            <label for="m3"> <%=m3 %> </label>
                            <input type="number" id="m3" runat="server" required >
                          </div>
                      </div>  
                     <asp:Button ID="btnactivity" runat="server" Text="Set activity" OnClick="btnactivity_Click"></asp:Button>
               
                </div>

        </form>

      </main>
    </div>  
   </body>
  </html>
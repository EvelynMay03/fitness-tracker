<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goals.aspx.cs" Inherits="DDOCP_MMM.goals" %>

<%@import Namespace="DDOCP_MMM" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="dashboard.css">
    <script src="https://kit.fontawesome.com/4899ddefbc.js" crossorigin="anonymous"></script>
    <title>Goals and Progresses</title>
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
                <a href="activity.aspx" >Activities</a>
                <a href="progress.aspx"  >  Progresses</a>
                <a href="goals.aspx" class="active" >Goals</a>
            </nav>
        </div>
     </header>
        <section>
            <asp:Label ID="output" runat="server" Text=""></asp:Label>
            <form id="setgoal" runat="server" >
              <div class="setgoal">

   
                   <h2>Set Your Goal for Today:</h2>
                   
                    <input type="number" id="goalc" runat="server" min="1" required>
                   
                    <asp:Button ID="btngoal" runat="server" Text="Set Goal " OnClick="btngoal_Click"  />

              </div>
             </form>
        </section>
     
        
        <div class="container">
            <h2>Goals & Calories Burnt History</h2>

            <table>
            <thead>
                <tr>
                <th>Date</th>
                <th>Goals (Calories)</th>
                <th>Calories Burned</th>
                <th>Status</th>
                
                </tr>
            </thead>

             <tbody>
                <% foreach (var goal in goalslist) { %>
                    <tr>
                        <td><%= goal.GoalDate %></td>
                        <td><%= goal.Calorie %></td>
                        <%    double dailyTotal=0;
                             
                              
                              dailyTotal = database.getCaloriesLog(dataManager.getUserId(), goal.GoalDate);%>
                         <td> <%= dailyTotal  %></td>
                        <td class="<%= dailyTotal >= goal.Calorie ? "achieved" : "failed" %>">
                            <%= dailyTotal >= goal.Calorie ? "Achieved" : "Not Achieved" %>
                        </td>
                    </tr>
                <% 
                  
              }  %>
            </tbody>
           </table>
        </div>
    
</body>
</html>
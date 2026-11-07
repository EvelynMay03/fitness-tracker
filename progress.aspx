<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="progress.aspx.cs" Inherits="DDOCP_MMM.progress" %>
<%@ Import Namespace="DDOCP_MMM" %>

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
              <a href="progress.aspx" class="active" >  Progresses</a>
              <a href="goals.aspx" >Goals</a>
          </nav>
        </div>
     </header>
    <div class="setgoal">
      <h2>Check Your Progress for Today!</h2>
    </div>

    <div class="container">
        <div class="today">
          <h3>Today Progress Analysis</h3>
          <p>Date: <% string today = DateTime.Now.ToString("mm-dd-yyyy");
                      Response.Write(today); %></p>
        </div>
     
            <div class="title">
                <div>
                    <h2>Total Burned Calories</h2> 
                </div>
           
                <div class="cal" >
                    <p class="cal-text">Calories</p>
                    <p class="title-amount" runat="server" id="todayCalories">0</p>
                </div>
            </div>
            <div class="transactions">
            
                <div class="transaction">
            
                  <div class="details">
                     <i class="fa-solid fa-person-walking"></i>
                     <h3>Walking</h3>
                   </div>

                    <div class="cal">
                      <p class="cal-text">Calories</p>
                      <p class="amount" runat="server" id="walkingCalories">0</p>
                    </div>

                 </div>

          <div class="transaction">
            
            <div class="details">
                <i class="fa-solid fa-person-swimming"></i>
                <h3>Swimming</h3>
            </div>
            <div class="cal">
              <p class="cal-text">Calories</p>
              <p class="amount" runat="server" id="swimmingCalories">0</p>
            </div>
          </div>
           <div class="transaction">
            
            <div class="details">
                <i class="fa-solid fa-people-roof"></i>
              <h3>Pilates</h3>
            </div>
            <div class="cal">
              <p class="cal-text">Calories</p>
              <p class="amount" runat="server" id="pilatesCalories">0</p>
            </div>
          </div>
          <div class="transaction">
            
            <div class="details">
                <i class="fa-solid fa-table-tennis-paddle-ball"></i>
              <h3>Badminton</h3>
            </div>
            <div class="cal">
              <p class="cal-text">Calories</p>
              <p class="amount"  runat="server" id="badmintonCalories">0</p>
            </div>
          </div>
          <div class="transaction">
            
            <div class="details">
                <i class="fa-solid fa-golf-ball-tee"></i>
              <h3>Golf</h3>
            </div>
            <div class="cal">
              <p class="cal-text">Calories</p>
              <p class="amount" runat="server" id="golfCalories">0</p>
            </div>
          </div>
          <div class="transaction">
            
            <div class="details">
                <i class="fa-solid fa-person-running"></i>
              <h3>Running</h3>
            </div>
            <div class="cal">
              <p class="cal-text">Calories</p>
              <p class="amount" runat="server" id="runningCalories">0</p>
            </div>
          </div>
          
        </div>
      
</body>
</html>

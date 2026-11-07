<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="DDOCP_MMM.signup" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="Style.css">
    <title>Sign Up</title>
    <script src="https://kit.fontawesome.com/4899ddefbc.js" crossorigin="anonymous"></script>
</head>
<body>
   
     <header>
          <div class="dashboard">
            <div class="logo">
                <div >
                    <i class="fa-solid fa-dumbbell"></i>
                </div>
                <div >
                    <p>Better Health Fitness Tracker</p>
                </div>
                
            </div>
            <nav class="switch">
               <a href="signup.aspx"  class="active">Sign Up</a>
               <a href="login.aspx" >Log In</a>
            </nav>
         </div>
    </header>
    <div class="flexbox">
        
        <div class="left">
           
        </div>
        <div class="right">
            
            <form id="signin" runat="server">
                
                <div class="boxform">
                    <p class="msg">Get started and Join us now to build</p>
                    <h1>Healthier & Better Version of Yourself!</h1>
                    <div class="info">
                        <label for="Name">Name</label>
                        <input type="text" id="username" required pattern="^[a-zA-Z0-9]+$" placeholder="Enter username."  runat="server">
                    </div>
                    <div class="info">
                        <label for="Password">Password</label>
                        <input type="password" id="password"  required pattern="^(?=.*[A-Z])(?=.*[A-Z])[a-zA-Z0-9!@#$%^&*]{12}$" placeholder="Enter password." runat="server">
                    </div>
                    <div class="info">
                        <label for="Confirm Password">Confirm Password</label>
                        <input type="password" id="confirm" placeholder="Enter password again!" runat="server">
                    </div>
                    
                    <div class="btn">
                        <asp:Button ID="btnclear" runat="server" Text="Clear" />
                        <asp:Button ID="btncreate" runat="server" Text="Create account" OnClick="btncreate_Click" />
                      
                    </div>
                <asp:Label ID="output" runat="server" Text=""></asp:Label>
                    <p class="msg">Already a member? <a href="login.html" >Log in</a></p> 
                </div>
                
                  
            </form>
        </div>
    </div>
</body>
</html>
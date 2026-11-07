<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DDOCP_MMM.login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
    <link rel="stylesheet" href="Style.css">
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
               <a href="signup.aspx"  >Sign Up</a>
               <a href="login.aspx" class="active">Log In</a>
            </nav>
         </div>
    </header>

        
        <div class="flexbox">
            
            <div class="left">
               
            </div>
            <div class="right">
        
                <form  id="login" runat="server">
                    <div class="boxform">
                        <h1 >Welcome Back!</h1>
                        <div class="info">
                            <label for="Name">Name</label>
                            <input type="text" id="username" placeholder="Enter username." runat="server" required>
                        </div>
                        <div class="info">
                            <label for="Password">Password</label>
                            <input type="password" id="password" placeholder="Enter password." runat="server" required>
                        </div>
                        
                        <div class="btn">
                            <asp:Button ID="btnlogin" runat="server" Text="Log In" OnClick="btnlogin_Click" />
                            
                            <br />
                            
                        </div>
                        <asp:Label ID="output" runat="server" Text=""></asp:Label>
                        <p class="msg">Forget Password? <a href="pswrecover.html" id="underline" >Recover Password Here!</a></p>    
                        <p class="msg">Not a member? <a href="signup.html" id="underline">Register Now</a></p>    
                    </div>
                   
                    
                </form>
            </div>
        </div>
</body>
</html>
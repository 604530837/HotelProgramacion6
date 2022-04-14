<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="HotelProgramacion6.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link  rel="stylesheet" href="Styles.css"/>
    <title>Inicio</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2 >Bienvenido</h2>
        <h1>Hotel El Paso</h1>
          <div class="btns">
                     <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Administracion" OnClick="Button1_Click" />
                    
                    <asp:Button ID="Button2"  CssClass="btn" runat="server" Text="Clientes" OnClick="Button2_Click" />
              </div>
    <div class="video">
        <div class="overlay">
            <div class="contenedor contenido-video">
                
              
                 
            </div>
        </div>
        <video autoplay muted loop>
            <source src="video/videohotel.mp4" type="video/mp4">
            
        </video>
    </div>
       
        
       
        
                    
                   
       
        
       
    </form>
</body>
</html>

<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link  rel="stylesheet" href="Styles.css"/>
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   


        <h2>Contacto</h2>
        <div class="wrapper-contacto">
            <div class="form-group">
                <label for="exampleInputEmail1">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Correo:</label>
                 <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
             <div class="form-group">
                <label for="exampleInputPassword1">Mensaje:</label>
                <textarea id="txtMensaje" cols="20" name="S1" rows=""></textarea>
            </div>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
        </div>
    </form>
    <p>
        </p>
</body>
</html>

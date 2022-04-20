<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservacion.aspx.cs" Inherits="HotelProgramacion6.Reservacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label15" runat="server" Text="Habitacion:"></asp:Label>
             <asp:DropDownList ID="ddlHabitacion" runat="server">
                 </asp:DropDownList>
        </div>
       
        <div>
             <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
             <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        
        <div>
             <asp:Label ID="Label2" runat="server" Text="Cedula:"></asp:Label>
             <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        </div>
        <div>
             <asp:Label ID="Label3" runat="server" Text="Correo Electronico:"></asp:Label>
             <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        </div>
         <div>
             <asp:Label ID="Label4" runat="server" Text="Telefono:"></asp:Label>
             <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </div>
        <div>
             <asp:Label ID="Label5" runat="server" Text="Adultos:"></asp:Label>
             <asp:TextBox ID="txtAdultos" runat="server"></asp:TextBox>
        </div>
        <div>
             <asp:Label ID="Label6" runat="server" Text="Niños:"></asp:Label>
             <asp:TextBox ID="txtNinos" runat="server"></asp:TextBox>
        </div>
       <div class="grid-calendarios">
            <div>
                 <asp:Label ID="Label7" runat="server" Text="Ingreso:"></asp:Label>
                 <asp:Calendar ID="calIngreso" runat="server"></asp:Calendar>
            </div>
           <div>
                 <asp:Label ID="Label8" runat="server" Text="Salida:"></asp:Label>
                 <asp:Calendar ID="calSalida" runat="server"></asp:Calendar>
                 
                 
                 
            </div>
           <div>
                <asp:Label ID="Label9" runat="server" Text="Tipo Alimentacion:"></asp:Label>
               <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                   <asp:ListItem>3 Tiempos</asp:ListItem>
                   <asp:ListItem>Ejecutiva</asp:ListItem>
                   <asp:ListItem>Todo Incluido</asp:ListItem>
                 </asp:RadioButtonList>
           </div>
          
           <div>
                <div>
                     <asp:Label ID="Label12" runat="server" Text="Dias:"></asp:Label>
                     <asp:TextBox ID="txtDias" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div>
                     <asp:Label ID="Label10" runat="server" Text="Hospedaje:"></asp:Label>
                     <asp:TextBox ID="txtHospedaje" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div>
                     <asp:Label ID="Label11" runat="server" Text="Alimentacion:"></asp:Label>
                     <asp:TextBox ID="txtAlimentacion" runat="server" Enabled="False"></asp:TextBox>
                </div>
               
                <div>
                     <asp:Label ID="Label13" runat="server" Text="Impuestos:"></asp:Label>
                     <asp:TextBox ID="txtImpuesto" runat="server" Enabled="False"></asp:TextBox>
                </div>
               <div>
                     <asp:Label ID="Label14" runat="server" Text="Total:"></asp:Label>
                     <asp:TextBox ID="txtTotal" runat="server" Enabled="False"></asp:TextBox>
                </div>
           </div>
       </div>
        <asp:Button ID="btnReservar" runat="server" Text="Reservar" />
    </form>
</body>
</html>

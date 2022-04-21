<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="HotelProgramacion6.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link  rel="stylesheet" href="Styles.css"/>
    <title>Clientes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
           <nav>
                <asp:TreeView ID="TreeView1" runat="server">
                    <Nodes>
                        <asp:TreeNode Text="Menu" Value="Menu">
                            <asp:TreeNode Text="Informacion" Value="Informacion"></asp:TreeNode>
                            <asp:TreeNode Text="Reservacion" Value="Reservacion">
                                <asp:TreeNode Text="Sumario" Value="Sumario"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Galeria" Value="Galeria"></asp:TreeNode>
                            <asp:TreeNode Text="Contacto" Value="Contacto"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
           </nav>
            <main>
            <h1>Hotel</h1>
            <h2>Lorem ipsum dolor sit amet, color dicta qui.</h2>
            <img src="https://logovectordl.com/wp-content/uploads/2021/12/hotel-palome-logo-vector.png" alt="">
            <section>
                <article>
                    <h3>Quienes somos</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit reiciendis ea deserunt illo a sed non excepturi ad nemo sit unde, architecto vero natus nulla, odit voluptatem inventore dolore facilis?</p>
                </article>
                <article>
                    <h3>Objectivos</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit reiciendis ea deserunt illo a sed non excepturi ad nemo sit unde, architecto vero natus nulla, odit voluptatem inventore dolore facilis?</p>
                </article>
                <article>
                    <h3>Principios</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit reiciendis ea deserunt illo a sed non excepturi ad nemo sit unde, architecto vero natus nulla, odit voluptatem inventore dolore facilis?</p>
                </article>
            </section>

        </main>
        </div>
       
    </form>
</body>
</html>

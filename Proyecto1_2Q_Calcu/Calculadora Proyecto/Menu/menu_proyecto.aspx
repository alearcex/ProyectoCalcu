<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_proyecto.aspx.cs" Inherits="webCalculadora1.Calculadora_Proyecto.Menu.menu_proyecto" %>

<!DOCTYPE html lang="es">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    <title>Primer Proyecto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
            <br />
            <header>
                <h1>Primer Proyecto</h1>
                <h2>Calculadora Web</h2>
            </header>
            <article class="contenedor-texto">
                <asp:TextBox ID="Tvalor1" runat="server" CssClass="redondeado-txt"></asp:TextBox>
            </article>
            <br />
            <section class="contenedor-botones">
                <asp:Button ID="Braiz" runat="server" OnClick="RaizClick" Text="√" CssClass="boton" />
                <asp:Button ID="BC" runat="server" OnClick="LimpiarClick" Text="CE" CssClass="boton" />
                <asp:Button ID="Bborrar" runat="server" OnClick="BorrarClick" Text="c" CssClass="boton" />
                <asp:Button ID="Bfact" runat="server" OnClick="FactClick" Text="n!" CssClass="boton" />
                <asp:Button ID="Bdivision" runat="server" OnClick="OperacionClick" Text="÷" CssClass="boton" />
            </section>
            <section class="contenedor-botones">
                <asp:Button ID="Bexpo" runat="server" OnClick="OperacionClick" Text="xⁿ" CssClass="boton" />
                <asp:Button ID="B7" runat="server" OnClick="NumerosClick" Text="7" CssClass="botones-num" />
                <asp:Button ID="B8" runat="server" OnClick="NumerosClick" Text="8" CssClass="botones-num" />
                <asp:Button ID="B9" runat="server" OnClick="NumerosClick" Text="9" CssClass="botones-num" />
                <asp:Button ID="Bmulti" runat="server" OnClick="OperacionClick" Text="×" CssClass="boton" />
            </section>
            <section class="contenedor-botones">
                <asp:Button ID="B10x" runat="server" Text="10ⁿ" CssClass="boton" OnClick="B10xClick" />
                <asp:Button ID="B4" runat="server" OnClick="NumerosClick" Text="4" CssClass="botones-num" />
                <asp:Button ID="B5" runat="server" OnClick="NumerosClick" Text="5" CssClass="botones-num" />
                <asp:Button ID="B6" runat="server" OnClick="NumerosClick" Text="6" CssClass="botones-num" />
                <asp:Button ID="Bmenos" runat="server" OnClick="OperacionClick" Text="-" CssClass="boton" />
            </section>
            <section class="contenedor-botones">
                <asp:Button ID="Blog" runat="server" OnClick="LogClick" Text="log" CssClass="boton" />
                <asp:Button ID="B1" runat="server" OnClick="NumerosClick" Text="1" CssClass="botones-num" />
                <asp:Button ID="B2" runat="server" OnClick="NumerosClick" Text="2" CssClass="botones-num" />
                <asp:Button ID="B3" runat="server" OnClick="NumerosClick" Text="3" CssClass="botones-num" />
                <asp:Button ID="Bmas" runat="server" OnClick="OperacionClick" Text="+" CssClass="boton" />
            </section>
            <section class="contenedor-botones">
                <asp:Button ID="Bcuadrado" runat="server" OnClick="CuadradoClick" Text="x²" CssClass="boton" />
                <asp:Button ID="Bmasmenos" runat="server" OnClick="MasMenosClick" Text="+/-" CssClass="boton" />
                <asp:Button ID="B0" runat="server" OnClick="NumerosClick" Text="0" CssClass="botones-num" />
                <asp:Button ID="Bpunto" runat="server" OnClick="PuntoClick" Text="." CssClass="boton" />
                <asp:Button ID="Bigual" runat="server" OnClick="IgualClick" Text="=" CssClass="boton" />
            </section>
            <br />
            <br />
            <footer>
                <h5>Adrian Gutiérrez Carballo &bull; Alessandro Arce Chaves &bull; Johan Andrey Ortega León</h5>
            </footer>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ExamenFinal.Vistas.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="SELECCIONE  LA  OPCION  DESEADA"></asp:Label>
            <div>
                <asp:Button ID="BUsuarios" runat="server" Text="Gestion de Usuarios" OnClick="BUsuarios_Click" />

       
                <asp:Button ID="BRegistroSalidas" runat="server" Text="Registro de Salidas" OnClick="BRegistroSalidas_Click" />
       
       
            <asp:Button ID="BRegistroEntradas" runat="server" Text="Registro de Entradas" />
       </div>
       </div>
    </form>
</body>
</html>

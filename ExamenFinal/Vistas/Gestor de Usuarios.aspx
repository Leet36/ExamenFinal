<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestor de Usuarios.aspx.cs" Inherits="ExamenFinal.Vistas.Gestor_de_Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el ID del usuario"></asp:Label>
            <asp:TextBox ID="TIngresoIdUsuario" runat="server"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label2" runat="server" Text="Ingrese el Nombre"></asp:Label>
            <asp:TextBox ID="TIngresoNombre" runat="server"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label3" runat="server" Text="Ingrese el primer apellido"></asp:Label>
            <asp:TextBox ID="TApellido1" runat="server"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label4" runat="server" Text="Ingrese el segundo apellido"></asp:Label>
            <asp:TextBox ID="TApellido2" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Button ID="BIngresoDatosUsuario" runat="server" Text="Aceptar" OnClick="BIngresoDatosUsuario_Click" />
            </div>
           
            <div>
            <asp:Button ID="BModificarUsuario" runat="server" Text="Modificar" OnClick="BIngresoDatosUsuario_Click" />
            </div>
            <div>
            <asp:Label ID="Label5" runat="server" Text="Para modifciar los datos de un usuario ingrese el numero de ID"></asp:Label>
            </div>

             <div>
             <asp:Button ID="BEliminarUsuario" runat="server" Text="Eliminar" OnClick="BIngresoDatosUsuario_Click" />
             </div>
             <div>
             <asp:Label ID="Label6" runat="server" Text="Para eliminar los datos de un usuario ingrese el numero de ID"></asp:Label>
             </div>



        </div>
    </form>
</body>
</html>

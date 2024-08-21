<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro Salidas.aspx.cs" Inherits="ExamenFinal.Vistas.Registro_Salidas" %>

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
           <asp:Label ID="Label1" runat="server" Text="Ingres el ID"></asp:Label>
           <asp:TextBox ID="TIdSalida" runat="server"></asp:TextBox>
           </div>
           <div>
           <asp:Label ID="Label2" runat="server" Text="IngresE El Pais de Destino"></asp:Label>
           <asp:TextBox ID="TPD" runat="server"></asp:TextBox>
           </div>
           <div>
           <asp:Label ID="Label3" runat="server" Text="Ingrese el Aeropuerto de Salida"></asp:Label>
           <asp:TextBox ID="TAS" runat="server"></asp:TextBox>
           </div>
           <div>
           <asp:Label ID="Label4" runat="server" Text="Ingrese el Aeropuerto de Destino"></asp:Label>
           <asp:TextBox ID="TAD" runat="server"></asp:TextBox>
           </div>
           <div>
           <asp:Label ID="Label5" runat="server" Text="Ingrese la Fecha de Salida"></asp:Label>
           <asp:TextBox ID="TFE" runat="server"></asp:TextBox>
           </div>
           
           <asp:Label ID="Label7" runat="server" Text="Ingrese la Hora de Salida"></asp:Label>
           <asp:TextBox ID="THE" runat="server"></asp:TextBox>
           </div>

           <div>
               <asp:Button ID="BAgregarSalida" runat="server" Text="Agregar" OnClick="BAgregarSalida_Click" />
           </div>

                        





        

        </div>
    </form>
</body>
</html>

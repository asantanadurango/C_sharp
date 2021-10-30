<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form_medico.aspx.cs" Inherits="Capas.form_medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td>ID MEDICO</td>
                                <td>
                                    <asp:TextBox ID="tbIdmedico" runat="server"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>NOM MEDICO</td>
                                <td>
                                    <asp:TextBox ID="tbNommedico" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtnommedico" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>ESPECIALIDAD</td>
                                <td>
                                    <asp:TextBox ID="tbEspecialidad" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtespecialidad" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">TEL MEDICO</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbTelmedico" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style2">
                                    <asp:Label ID="txttelmedico" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>ACTIVO</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Label ID="txtactivo" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                                </td>
                                <td>
                        <asp:Button ID="btnConsultar" runat="server" Text="consultar" OnClick="btnConsultar_Click" />
                                </td>
                                <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

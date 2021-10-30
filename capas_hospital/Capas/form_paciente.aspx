<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form_paciente.aspx.cs" Inherits="Capas.form_paciente" %>

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
        .auto-style3 {
            height: 26px;
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
                                <td>ID PACIENTE</td>
                                <td>
                                    <asp:TextBox ID="tbIdpaciente" runat="server"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>TIP. DOC.</td>
                                <td>
                                    <asp:TextBox ID="tbTipdoc" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txttipdoc" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>NOM PACIENTE</td>
                                <td>
                                    <asp:TextBox ID="tbNompaciente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtnompaciente" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">DIR PACIENTE</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbDirpaciente" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style2">
                                    <asp:Label ID="txtdirpaciente" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">TEL PACIENTE</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbTelpaciente" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style2">
                                    <asp:Label ID="txttelpaciente" runat="server"></asp:Label>
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
                                <td class="auto-style3"></td>
                                <td class="auto-style3">
                                    </td>
                                <td class="auto-style3"></td>
                            </tr>
                            <tr>
                                <td class="auto-style3"></td>
                                <td class="auto-style3">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </td>
                                <td class="auto-style3"></td>
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

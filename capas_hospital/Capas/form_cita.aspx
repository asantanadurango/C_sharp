<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form_cita.aspx.cs" Inherits="Capas.form_cita" %>

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
                                <td>CODIGO CITA</td>
                                <td>
                                    <asp:TextBox ID="tbCodcita" runat="server"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>FECHA</td>
                                <td>
                                    <asp:TextBox ID="tbFecha" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtfecha" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>HORA</td>
                                <td>
                                    <asp:TextBox ID="tbHora" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txthora" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">ID PACIENTE</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbIDpaciente" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style2">
                                    <asp:Label ID="txtidpaciente" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>ID MEDICO</td>
                                <td>
                                    <asp:TextBox ID="tbIdmedico" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtidmedico" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>VALOR</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="tbValor" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style2">
                                    <asp:Label ID="txtvalor" runat="server" ValidateRequestMode="Enabled"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>DIAGNOSTICO</td>
                                <td>
                                    <asp:TextBox ID="tbDiagnostico" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtdiagnostico" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>NOMBRE ACOMPAÑANTE</td>
                                <td>
                                    <asp:TextBox ID="tbAcompa" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="txtnomacopañante" runat="server"></asp:Label>
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
                                <td>
                        <asp:Button ID="btnConsultar" runat="server" Text="consultar" OnClick="btnConsultar_Click" />
                                </td>
                                <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                </td>
                                <td>
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
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

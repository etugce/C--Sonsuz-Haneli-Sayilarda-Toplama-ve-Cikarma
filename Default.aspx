<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN">

<html>
<head runat="server">
<title5>TEST Versiyon 2021</title5>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 30px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style5 {
            width: 150px;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <asp:Label ID="Label_kullanici" runat="server" Visible="False"></asp:Label>
    <asp:Panel ID="Panel1" runat="server">
        <table style="width:100%;">
            <tr>
                <td style="width: 150px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">
                    Sayı 1</td>
                <td colspan="2">
                    <asp:TextBox ID="T_1" runat="server" Width="1200px" OnTextChanged="T_1_TextChanged" AutoPostBack="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">
                    Sayı 2</td>
                <td colspan="2">
                    <asp:TextBox ID="T_2" runat="server" Width="1200px" OnTextChanged="T_2_TextChanged" AutoPostBack="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style7" colspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2" width="5">
                    <asp:Button ID="B_1" runat="server" Text="Topla" OnClick="B_1_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="B_2_cikar" runat="server" Text="Çıkar" OnClick="B_2_cikar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style7" colspan="2"></td>
            </tr>
            <tr>
                <td style="width: 150px">Ters 1</td>
                <td colspan="2">
                    <asp:Label ID="L_1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style7" colspan="2"></td>
            </tr>
            <tr>
                <td style="width: 150px">Ters 2</td>
                <td colspan="2">
                    <asp:Label ID="L_2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 150px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">Sonuç</td>
                <td colspan="2">
                    <asp:TextBox ID="T_sonuc" runat="server" Width="1200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
</form>
</body>
</html>

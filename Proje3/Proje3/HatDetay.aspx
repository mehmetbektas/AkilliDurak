<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HatDetay.aspx.cs" Inherits="Proje3.HatDetay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            background-color:Olive;
            color:Yellow;
        }
        .style2
        {
            width: 81px;
        }
        .style3
        {
            width: 81px;
            color: Aqua;
        }
        .style4
        {
            width: 205px;
        }
        .style7
        {
            width: 141px;
            color: Aqua;
        }
        .style8
        {
            width: 141px;
        }
        .style9
        {
            width:100%;
            height:100%;
            background-color:Aqua;
        }
        .style10
        {
            height: 282px;
        }
        .style11
        {
            width: 651px;
            height: 278px;
        }
        .style12
        {
            height: 282px;
            width: 746px;
        }
        .style13
        {
            height: 282px;
            width: 438px;
        }
        .style14
        {
            width: 165px;
        }
        .style15
        {
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table class="style9"> 
    <tr>
    <td class="style12">&nbsp;</td>
    <td class="style13">
        <img alt="Durak" class="style11" src="otobusdurak.jpg" 
            style="font-size: inherit; font-family: 'Adobe Gothic Std B'; width: 884px; margin-left: 0px;" /></td>
    <td class="style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
    </tr>

    </table>


        <table class="style1">

        
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label4" runat="server" Text="Hat No" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="lblHatNo" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" Text="Neden" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="style14" colspan="2">
                    <asp:DropDownList ID="ddlNeden" runat="server" Height="35px" Width="150px" 
                        style="margin-left: 0px">
                        <asp:ListItem>Trafik</asp:ListItem>
                        <asp:ListItem>YolcuYogunlugu</asp:ListItem>
                        <asp:ListItem>Kaza</asp:ListItem>
                        <asp:ListItem>Ariza</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label5" runat="server" Text="Durak No" BorderStyle="Ridge"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="lblDurakNo" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="HavaDurumu" BorderStyle="Ridge"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="ddlHavaDurumu" runat="server" Height="35px" Width="150px">
                        <asp:ListItem>Karli</asp:ListItem>
                        <asp:ListItem>Normal</asp:ListItem>
                        <asp:ListItem>Yagisli</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style8">
                    <asp:Label ID="lblb1" runat="server" Text="Olması Gereken Saat"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="lblDOGS" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    <asp:Label ID="lbl2" runat="server" Text="Rötar Miktarı"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="lblGecikme" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    <asp:Label ID="lbl3" runat="server" Text="Geleceği Saat"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="lblGelecegiSaat" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td colspan="2" class="style15">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:TextBox ID="txtMail" runat="server" Width="183px">mehmetbektas69@gmail.com</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <br />
                    <br />
                    <br />
                </td>
                <td class="style7">
                    &nbsp;</td>
                <td colspan="2" class="style15">
                    <asp:Button ID="btnHesapla" runat="server" onclick="btnHesapla_Click" 
                        Text="Ne Zaman Gelecek" Height="37px" Width="200px" />
                </td>
                <td colspan="2">
                    <asp:Button ID="btnMail" runat="server" Height="35px" onclick="btnMail_Click" 
                        Text="Mail Gönder" Width="184px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

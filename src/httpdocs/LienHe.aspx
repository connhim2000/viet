<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LienHe.aspx.cs" Inherits="LienHe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<table class="table_tour_cre" 
        style="background-image: url('images/site/dattour_bgimg.jpg'); background-repeat: no-repeat;padding-top: 25px; padding-left: 20px">
    <tr>
        <td colspan="2">
            <div align="left"><img src="Images/site/lienhe.jpg" alt="lien he" /></div>
            <br />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="padding-left: 38px">
            <div align="left" class="txt_footer" style="width:400px; text-align:justify">
                <b>Good Networ Tourservice.korea (Company Name)</b><br /><br />
                ADD:#407, Hwaseong Bd, 234-5, Guui-1dong, Gwangjingu, Seoul, Republic of Korea.<br />                TEL:070-7636-6626<br />
                E-mail:hengao@empas.com
                <br />
                <br />
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam non justo quam. In vehicula luctus mi vel consectetur. Ut et erat at libero lacinia venenatis. Fusce velit libero, euismod eget ullamcorper et, facilisis at dolor. Suspendisse facilisis odio at sapien tempus rutrum. 
            </div>
            <br />
        </td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label8" runat="server" Text="Họ tên" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="288" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label9" runat="server" Text="Địa chỉ" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="288" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label10" runat="server" Text="Email" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="288" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label1" runat="server" Text="Điện thoại" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="288" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label2" runat="server" Text="Ý kiến" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Width="288px" CssClass="textbox" TextMode="MultiLine" Height="96px"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2" style="padding-left: 38px">
            <br />
             <div style="text-align:right; width:400px">
                 <asp:LinkButton ID="LinkButton1" runat="server" CssClass="lbl_tour_cre">Hủy</asp:LinkButton>&nbsp;&nbsp;<span class="lbl_tour_cre">|</span>&nbsp;&nbsp;<asp:LinkButton
                     ID="LinkButton2" runat="server" CssClass="lbl_tour_cre">Gửi</asp:LinkButton></div>              
        </td>
    </tr>
</table>
</asp:Content>


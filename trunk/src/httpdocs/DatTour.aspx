<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DatTour.aspx.cs" Inherits="DatTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<table class="table_tour_cre" 
        style="background-image: url('images/site/dattour_bgimg.jpg'); background-repeat: no-repeat;padding-top: 25px; padding-left: 20px">
    <tr>
        <td colspan="2">
            <div align="left"><img src="Images/site/dattour.jpg" alt="dat tour" /></div>
            <br />
        </td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label8" runat="server" Text="Điểm đến" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="230" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label9" runat="server" Text="Ngày khởi hành" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="230" CssClass="textbox" Text="DD/MM/YYYY"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label10" runat="server" Text="Ngày trở về" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="230" CssClass="textbox" Text="DD/MM/YYYY"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label11" runat="server" Text="Khách sạn" CssClass="lbl_tour_cre"></asp:Label></td>
        <td valign="middle">
            <asp:TextBox ID="TextBox4" runat="server" Width="205" CssClass="textbox"></asp:TextBox>
            <asp:Label ID="Label18" runat="server" Text="sao" CssClass="lbl_tour_cre"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label12" runat="server" Text="Người lớn" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Width="80" CssClass="textbox"></asp:TextBox>
            &nbsp;&nbsp;<asp:Label ID="Label19" runat="server" Text="Trẻ em" CssClass="lbl_tour_cre"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="80" CssClass="textbox"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label13" runat="server" Text="Tên khách" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" Width="230" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label14" runat="server" Text="Điện thoại" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server" Width="230" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label15" runat="server" Text="Địa chỉ" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server" Width="230" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label16" runat="server" Text="Hướng dẫn viên" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox10" runat="server" Width="230" CssClass="textbox"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style1" style="padding-left: 38px">
            <asp:Label ID="Label17" runat="server" Text="Xe" CssClass="lbl_tour_cre"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox11" runat="server" Width="170" CssClass="textbox"></asp:TextBox>
            <asp:Label ID="Label20" runat="server" Text="chỗ ngồi" CssClass="lbl_tour_cre"></asp:Label>                   
        </td>
    </tr>
    <tr>
        <td colspan="2" style="padding-left: 38px">
            <br />
             <div style="text-align:right; width: 343px"><asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/Images/btn_dattour.jpg" /></div>              
        </td>
    </tr>
</table>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="HotelEdit.aspx.cs" Inherits="Amigtsvn_HotelEdit" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li><a href="Users.aspx">Người dùng</a></li>
    <li><a href="Role.aspx">Nhóm</a></li>
    <li><a href="Tour.aspx">Tour</a></li>
    <li><a href="Location.aspx">Địa điểm</a></li>
    <li><a href="Scenery.aspx">Địa điểm du lịch</a></li>
    <li class="current"><a href="Hotel.aspx">Khách sạn</a></li>
    <li><a href="Event.aspx">Sự kiện</a></li>
    <li><a href="Pictures.aspx">Hình ảnh</a></li>
    <li><a href="Management.aspx">Quản lý</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <div id="box">
    <h3 id="adduser">Sửa khách sạn <asp:Label ID="txtUN" runat="server" Text="" ForeColor="#3399FF"></asp:Label></h3>
        <table bgcolor="White" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td width="100">
                    ID :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtId" runat="server" ValidationGroup="users" ReadOnly="true" Width="40"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Tên khách sạn :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtNm" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Số sao :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtStar" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Giá phòng :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mô tả :
                </td>
                <td width="500">
                    <asp:TextBox ID="txtDescRev" runat="server" TextMode="MultiLine" Width="400" Height="150"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mô tả chi tiết :
                </td>
                <td width="600">
                    <CKEditor:CKEditorControl ID="CKEditor1" runat="server"></CKEditor:CKEditorControl>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Vị trí :
                </td>
                <td width="300">
                    <asp:DropDownList ID="ddLoca1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height:30px">
                    <asp:Label ID="lblStatus" runat="server" Text="" style="color:Red"></asp:Label>
                </td>
            </tr>
        </table>
      <div align="center">
          <asp:Button ID="btnSubmit" runat="server" Text="Sửa" 
              style="background-color: #7E9DCC; border-width: thin; color: #ffffff; width:60px; height:25px" 
              onclick="btnSubmit_Click" ValidationGroup="users" />
          <input id="button2" type="reset" style="background-color: #7E9DCC; border-width: thin; color: #ffffff; width:60px; height:25px" value="Hủy" />
      </div>
      <br />
      </div>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>


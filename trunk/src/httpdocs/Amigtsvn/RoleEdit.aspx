<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="RoleEdit.aspx.cs" Inherits="Amigtsvn_RoleEdit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li><a href="Users.aspx">Người dùng</a></li>
    <li class="current"><a href="Role.aspx">Nhóm</a></li>
    <li><a href="Tour.aspx">Tour</a></li>
    <li><a href="Location.aspx">Địa điểm</a></li>
    <li><a href="Scenery.aspx">Địa điểm du lịch</a></li>
    <li><a href="Hotel.aspx">Khách sạn</a></li>
    <li><a href="Event.aspx">Sự kiện</a></li>
    <li><a href="Pictures.aspx">Hình ảnh</a></li>
    <li><a href="Management.aspx">Quản lý</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <div id="box">
    <h3 id="adduser">Sửa thông tin nhóm <asp:Label ID="txtUN" runat="server" Text="" ForeColor="#3399FF"></asp:Label></h3>
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
                    Tên nhóm :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtNm" runat="server" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtNm" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập tên nhóm" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblNmStatus" runat="server" ForeColor="Red" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mô tả :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
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


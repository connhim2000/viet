<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="UsersEdit.aspx.cs" Inherits="Amigtsvn_UsersEdit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li class="current"><a href="Users.aspx">Người dùng</a></li>
    <li><a href="Role.aspx">Nhóm</a></li>
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
    <h3 id="adduser">Sửa thông tin người dùng <asp:Label ID="txtUN" runat="server" Text="" ForeColor="#3399FF"></asp:Label></h3>
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
                    Tên đăng nhập :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtUserName" runat="server" ValidationGroup="users" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mật khẩu :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="users"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Nhập lại mật khẩu :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtRetypePass" runat="server" TextMode="Password" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu nhập lại không đúng" ControlToCompare="txtPassword" ControlToValidate="txtRetypePass" SetFocusOnError="true" ValidationGroup="users"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Họ Tên :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtFullNm" runat="server" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtFullNm" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập họ và tên" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Địa chỉ :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtAddress" runat="server" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtAddress" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập địa chỉ" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Email :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="users" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Phân quyền :
                </td>
                <td width="300">
                    <asp:ListBox ID="lbRole" runat="server" SelectionMode="Multiple" Width="250"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Kích hoạt :
                </td>
                <td width="300">
                    <asp:CheckBox ID="ckActived" runat="server" />
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


<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Amigtsvn_Users" %>

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
    <h3>Danh sách người dùng</h3>
    <br />
    &nbsp; Chọn nhóm : 
    <asp:DropDownList ID="ddRole" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddRole_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
        GridLines="None" DataKeyNames="UserId" onrowcommand="gridMain_RowCommand" 
        AllowPaging="True" onpageindexchanging="gridMain_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="UserNm" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Họ Tên" DataField="FullNm" >
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Email" DataField="Email" >
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument= '<%# Eval("UserId") %>' >
                        <asp:Image ID="imgEdit" ImageUrl="~/Amigtsvn/img/icons/page_white_edit.png" ToolTip="Sửa, Phân quyền" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="SetStatus" CommandArgument= '<%# Eval("UserId") %>'>
                        <asp:Image ID="imgStatus" ImageUrl='<%# Eval("IsActived").ToString() == "True" ? "~/Amigtsvn/img/icons/unlock.png" : "~/Amigtsvn/img/icons/lock.png"%>' ToolTip='<%# Eval("IsActived").ToString() == "True" ? "Khóa" : "Mở khóa"%>' runat="server" />
                    </asp:LinkButton>
                </ItemTemplate>
                <ItemStyle Width="80px" />
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#7E9DCC" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#7E9DCC" Font-Bold="True" ForeColor="White" 
            Height="30px" />
        <PagerSettings FirstPageText="Đầu" LastPageText="Cuối" NextPageText="Sau" 
            PreviousPageText="Trước" />
        <PagerStyle BackColor="#ffffff" ForeColor="#7E9DCC" HorizontalAlign="Center" Width="100%" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
    <br />
    </div>
    <br />
    <div id="box">
    <h3 id="adduser">Thêm người dùng</h3>
        <table bgcolor="White" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td width="100">
                    Tên đăng nhập :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtUserName" runat="server" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUserName" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập tên đăng nhập" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblStUserNm" runat="server" ForeColor="Red" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mật khẩu :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPassword" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập mật khẩu" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Nhập lại mật khẩu :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtRetypePass" runat="server" TextMode="Password" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtRetypePass" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập lại mật khẩu" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu nhập lại không đúng" ControlToCompare="txtPassword" ControlToValidate="txtRetypePass" SetFocusOnError="true" ValidationGroup="users"></asp:CompareValidator>
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
                    <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="users"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtEmail"
                        Display="Dynamic" ErrorMessage="Vui lòng nhập Email" ValidationGroup="users"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                        Display="Dynamic" ErrorMessage="Vui lòng nhập email đúng định dạng"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="true" ValidationGroup="users"></asp:RegularExpressionValidator>
                    <asp:Label ID="lblStsEmail" runat="server" ForeColor="Red" Text=""></asp:Label>
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
                <td colspan="2" style="height:30px">
                    <asp:Label ID="lblStatus" runat="server" Text="" style="color:Red"></asp:Label>
                </td>
            </tr>
        </table>
      <div align="center">
          <asp:Button ID="btnSubmit" runat="server" Text="Thêm" 
              style="background-color: #7E9DCC; border-width: thin; color: #ffffff; width:60px; height:25px" 
              onclick="btnSubmit_Click" ValidationGroup="users" />
          <input id="button2" type="reset" style="background-color: #7E9DCC; border-width: thin; color: #ffffff; width:60px; height:25px" value="Hủy" />
      </div>
      <br />
      </div>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="Location.aspx.cs" Inherits="Amigtsvn_Location" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li><a href="Users.aspx">Người dùng</a></li>
    <li><a href="Role.aspx">Nhóm</a></li>
    <li><a href="Tour.aspx">Tour</a></li>
    <li class="current"><a href="Location.aspx">Địa điểm</a></li>
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
    <h3>Danh sách địa điểm</h3>
    <br />
    &nbsp; Chọn quốc gia : 
    <asp:DropDownList ID="ddCountry" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddCountry_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
        GridLines="None" DataKeyNames="LocaId" onrowcommand="gridMain_RowCommand" 
        AllowPaging="True" onpageindexchanging="gridMain_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="Tên địa điểm" DataField="LocaNm" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Mô tả" DataField="Description" >
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Thứ tự" DataField="Idx" >
            <ItemStyle Width="40px" />
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument= '<%# Eval("LocaId") %>' >
                        <asp:Image ID="imgEdit" ImageUrl="~/Amigtsvn/img/icons/page_white_edit.png" ToolTip="Sửa, Phân quyền" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="SetStatus" CommandArgument= '<%# Eval("LocaId") %>'>
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
    <h3 id="adduser">Thêm địa điểm</h3>
        <table bgcolor="White" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td width="100">
                    Tên địa điểm :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtNm" runat="server" ValidationGroup="users"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtNm" Display="Dynamic" 
                        ErrorMessage="Vui lòng nhập tên địa điểm" SetFocusOnError="True" ValidationGroup="users"></asp:RequiredFieldValidator>
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
                <td width="100">
                    Thứ tự :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtIdx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Quốc gia :
                </td>
                <td width="300">
                    <asp:DropDownList ID="ddCountry1" runat="server">
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


<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="Tour.aspx.cs" Inherits="Amigtsvn_Tour" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li><a href="Users.aspx">Người dùng</a></li>
    <li><a href="Role.aspx">Nhóm</a></li>
    <li class="current"><a href="Tour.aspx">Tour</a></li>
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
    <h3>Danh sách Tour</h3>
    <br />
    &nbsp; Chọn nhóm : 
    <asp:DropDownList ID="ddGroup" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddGroup_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
        GridLines="None" DataKeyNames="TourId" onrowcommand="gridMain_RowCommand" 
        AllowPaging="True" onpageindexchanging="gridMain_PageIndexChanging" 
        PageSize="5">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Hình đại diện">
                <ItemTemplate>
                    <asp:Image ID="imgPic" ImageUrl='<%# Eval("PicPath1", "../Images/site/TourImgs/{0}") %>' ToolTip='<%# Eval("TourNm") %>' runat="server" Height="71" Width="91" />
                </ItemTemplate>
                <ItemStyle Width="95px" />
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên Tour" DataField="TourNm" >
            <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Mô tả" DataField="DescReview" >
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument= '<%# Eval("TourId") %>' >
                        <asp:Image ID="imgEdit" ImageUrl="~/Amigtsvn/img/icons/page_white_edit.png" ToolTip="Sửa, Phân nhóm" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Picture" CommandArgument= '<%# Eval("TourId") %>' >
                        <asp:Image ID="Image1" ImageUrl="~/Amigtsvn/img/icons/picture_mng.png" ToolTip="Quản lý ảnh" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="SetStatus" CommandArgument= '<%# Eval("TourId") %>'>
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
    <h3 id="adduser">Thêm Tour</h3>
        <table bgcolor="White" border="0" cellpadding="0" cellspacing="0">
            <table bgcolor="White" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td width="100">
                    Tên Tour :
                </td>
                <td width="300">
                    <asp:TextBox ID="txtNm" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mô tả Tour:
                </td>
                <td width="500">
                    <asp:TextBox ID="txtDescRev" runat="server" TextMode="MultiLine" Width="400" Height="150"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Mô tả nội dung :
                </td>
                <td width="600">
                    <CKEditor:CKEditorControl ID="CKEditor1" runat="server"></CKEditor:CKEditorControl>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Chi tiết nội dung :
                </td>
                <td width="600">
                    <CKEditor:CKEditorControl ID="CKEditor2" runat="server"></CKEditor:CKEditorControl>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Nhóm tour :
                </td>
                <td width="300">
                    <asp:DropDownList ID="ddGroup1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Loại Tour :
                </td>
                <td width="300">
                    <asp:ListBox ID="lbKind" runat="server" SelectionMode="Multiple" Width="250"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td width="100">
                    Tour khuyến mãi :
                </td>
                <td width="300">
                    <asp:CheckBox ID="cbPromotion" runat="server" />
                </td>
            </tr>
            <tr>
                <td width="100">
                    Tour nổi bật :
                </td>
                <td width="300">
                    <asp:CheckBox ID="cbProminent" runat="server" />
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

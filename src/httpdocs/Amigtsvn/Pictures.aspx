<%@ Page Title="" Language="C#" MasterPageFile="~/Amigtsvn/Admin.master" AutoEventWireup="true" CodeFile="Pictures.aspx.cs" Inherits="Amigtsvn_Pictures" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<ul>
    <li><a href="Users.aspx">Người dùng</a></li>
    <li><a href="Role.aspx">Nhóm</a></li>
    <li><a href="Tour.aspx">Tour</a></li>
    <li><a href="Location.aspx">Địa điểm</a></li>
    <li><a href="Scenery.aspx">Địa điểm du lịch</a></li>
    <li><a href="Hotel.aspx">Khách sạn</a></li>
    <li><a href="Event.aspx">Sự kiện</a></li>
    <li class="current"><a href="Pictures.aspx">Hình ảnh</a></li>
    <li><a href="Management.aspx">Quản lý</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="box">
    <h3>Quản lý hình ảnh 
        <asp:Label ID="lblKindNm" runat="server" Text=""></asp:Label>&nbsp;<asp:Label
            ID="lblNm" runat="server" Text="" ForeColor="#3391f6"></asp:Label></h3>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
        GridLines="None" DataKeyNames="PicId" onrowcommand="gridMain_RowCommand" 
        AllowPaging="True" onpageindexchanging="gridMain_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Hình đại diện">
                <ItemTemplate>
                    <asp:Image ID="imgPic" ImageUrl='<%# Eval("FullPath", "../Images/site/{0}") %>' ToolTip='<%# Eval("ScenNm") %>' runat="server" Height="71" Width="91" />
                </ItemTemplate>
                <ItemStyle Width="95px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên hình">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("PicNm") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="80px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đường dẫn hình">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("FullPath") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="120px" />
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Picture" CommandArgument= '<%# Eval("EventId") %>' >
                        <asp:Image ID="Image1" ImageUrl="~/Amigtsvn/img/icons/picture_mng.png" ToolTip="Quản lý ảnh" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="SetStatus" CommandArgument= '<%# Eval("EventId") %>'>
                        <asp:Image ID="imgStatus" ImageUrl='<%# Eval("IsActived").ToString() == "True" ? "~/Amigtsvn/img/icons/unlock.png" : "~/Amigtsvn/img/icons/lock.png"%>' ToolTip='<%# Eval("IsActived").ToString() == "True" ? "Khóa" : "Mở khóa"%>' runat="server" />
                    </asp:LinkButton>
                </ItemTemplate>
                <ItemStyle Width="60px" />
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
    </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <table>
        <tr>
            <td>
                <span style="color: #0453a8">Chọn file upload (tối đa 5 file và 2mb, chỉ chấp nhận loại file gif, jpg, jpeg, png)</span>
                <br />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" class="multi" maxlength="5" accept="gif|jpg|jpeg|png"/>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:Button ID="btnUpload" runat="server" Text="Bắt đầu upload" style="background-color: #7E9DCC; border-width: thin; color: #ffffff; width:120px; height:25px" 
                    onclick="btnUpload_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblStatus" runat="server" Font-Size="10px"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblKind" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblLoadSts" runat="server" Text=""></asp:Label>
</div>
</asp:Content>


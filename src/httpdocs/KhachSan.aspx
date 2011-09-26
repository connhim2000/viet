<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="KhachSan.aspx.cs" Inherits="KhachSan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<table class="table_tour_cre" style="vertical-align:top">
    <tr style="vertical-align:top">
        <td>
            <table class="tbl_tour_list">
                <asp:Repeater ID="RepLoca" runat="server">
                    <ItemTemplate>
                        <tr class='<%# Eval("LocaId").ToString() == Request.QueryString["LocaId"] ? "tbl_tour_list_selected" : ""%>'>
                            <td>
                                <div><asp:HyperLink ID="HyperLink1" runat="server" CssClass="lbl_tour_cre" NavigateUrl='<%# "KhachSan.aspx?LocaId=" + Eval("LocaId")%>' ToolTip='<%# Eval("Description") %>'><%# Eval("LocaNm") %></asp:HyperLink></div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </td>
        <td style="width: 100%">
            <table class="table_tour_cre" style="background-image: url('images/site/tourtrongoi_bgimg.png'); background-repeat: no-repeat;padding-top: 20px; padding-left: 30px">
                <asp:Repeater ID="RepHotel" runat="server">
                    <ItemTemplate>
                        <tr style="width: 500px">
                            <td>
                                <a href='ChiTietKhachSan.aspx?HotelId=<%# Eval("HotelId")%>'>
                                    <img style="width:91px; height:71px; vertical-align:top" src='Images/site/TourImgs/<%# Eval("PicPath1") %>' border="0"/>
                                </a>
                            </td>
                            <td>
                                <div class="tour_content">
                                    <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/TourTronGoi.aspx" style="text-decoration:none"><b><%# Eval("HotelNm") %></b></asp:HyperLink><br /><br />
                                    <%# Eval("Description") %>
                                </div>
                            </td>
                        </tr>
                        <tr style="width: 500px">
                            <td colspan="2">
                                <img src="images/site/tourtrongoi_sper.jpg" width="745px" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </td>
    </tr>
</table>
</asp:Content>


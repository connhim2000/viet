<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="KhachSan.aspx.cs" Inherits="KhachSan" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<table class="table_tour_cre" style="vertical-align:top">
    <tr style="vertical-align:top">
        <td>
            <table class="tbl_tour_list">
                <asp:Repeater ID="RepLoca" runat="server">
                    <ItemTemplate>
                        <tr class='<%# Eval("LocaId").ToString() == Request.QueryString["LocaId"] ? "tbl_tour_list_selected" : ""%>' style="cursor: pointer" onclick="DoClick('<%# "KhachSan.aspx?LocaId=" + Eval("LocaId")%>');">
                            <td>
                                <div class="lbl_tour_cre"><%# Eval("LocaNm") %></div>
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
                        <tr>
                            <td>
                                <a href='ChiTietKhachSan.aspx?HotelId=<%# Eval("HotelId")%>'>
                                    <img style="width:91px; height:71px" src='Images/site/Hotel/<%# Eval("PicPath1") %>' border="0"/>
                                </a>
                            </td>
                            <td class="tour_content_nopadtop">
                                <div style="width:633px">
                                    <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl='<%#Eval("HotelId","ChiTietKhachSan.aspx?HotelId={0}")%>' style="text-decoration:none"><b><%# Eval("HotelNm") %></b></asp:HyperLink><br /><br />
                                    <%# Eval("DescReview") %>
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
            <div style="width:771px" align="right">
                <cc1:CollectionPager ID="CollectionPager1"
                    FirstText="Đầu" 
                    BackText="« Trước &amp;nbsp;" 
                    LabelText="" 
                    LastText="Cuối" 
                    NextText="&amp;nbsp; Sau »" 
                    ShowFirstLast="True" 
                    SliderSize="5" PagingMode="PostBack"
                    runat="server" BackNextLinkSeparator="" BackNextLocation="Split" 
                    PageNumbersDisplay="Numbers" ResultsLocation="None" 
                    BackNextDisplay="HyperLinks" ControlCssClass="tour_content_paging">
                </cc1:CollectionPager>
            </div>
        </td>
    </tr>
</table>
<br />
</asp:Content>


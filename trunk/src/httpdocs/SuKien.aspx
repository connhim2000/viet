<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SuKien.aspx.cs" Inherits="SuKien" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<table class="table_tour_cre" style="vertical-align:top">
    <tr style="vertical-align:top">
        <td>
            <table class="tbl_tour_list">
                <tr class="tbl_tour_list_selected">
                    <td>
                        <div><asp:HyperLink ID="HyperLink1" runat="server" CssClass="lbl_tour_cre" NavigateUrl="Sukien.aspx">Lịch sự kiện</asp:HyperLink></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="lbl_tour_cre" NavigateUrl="Sukien.aspx">Danh sách sự kiện</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
        <td style="width: 100%" class="lbl_tour_cre">
            <table style="width: 100%; background-image: url('images/site/tourtrongoi_bgimg.png'); background-repeat: no-repeat;padding-top: 20px; padding-left: 30px">
                <tr style="height: 40px">
                    <td style="width: 50px">
                        Ngày Tháng
                    </td>
                    <td style="width: 200px; text-align:center; padding-right: 20px">
                        Sự kiện
                    </td>
                    <td style="width: 50px">
                        Địa điểm
                    </td>
                    <td style="width:120px">
                    </td>
                </tr>
                <asp:Repeater ID="repMain" runat="server">
                <ItemTemplate>
                    <tr style="font-weight: normal; height: 30px">
                        <td style="width: 50px">
                            <%# Eval("FromDate","{0:dd/MM/yyyy}") %>
                        </td>
                        <td style="width: 200px; padding-right: 20px;">
                            <a href='ChiTietSuKien.aspx?eventid=<%# Eval("EventId") %>' class="event_title"><%# Eval("EventNm") %></a>
                        </td>
                        <td style="width: 50px">
                            <%# Eval("LocaNm") %>
                        </td>
                        <td style="width:120px">
                        </td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>
            </table>
            <br />
            <br />
            <div style="width:550px; font-weight: normal" align="right">
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
</asp:Content>


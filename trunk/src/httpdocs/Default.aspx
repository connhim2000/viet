<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<table class="tbl_child" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>
            <div align="left"><img src="Images/site/tour_khuyen_mai.jpg" alt="tour khuyen mai" /></div>
            <table class="table_tour">
                <tr>
                    <asp:Repeater ID="RepPromotion" runat="server">
                    <ItemTemplate>
                        <td width="150px">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td height="50px">
                                        <a href='ChiTietTour.aspx?TourId=<%# Eval("TourId")%>' class="tour_header"><%# Eval("TourNm")%></a>
                                    </td>
                                </tr>
                            </table>
                            <a href='ChiTietTour.aspx?TourId=<%# Eval("TourId")%>'>
                                    <img class="img_km" src='Images/site/TourImgs/<%# Eval("PicPath1") %>' border="0" align="middle" />
                            </a>
                            <br />
                            <div class="tour_content" padding="5px" ><%# Eval("DescReview")%></div>
                            <div style="text-align:right; padding-top: 7px;width: 145px; padding-right:5px"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/btn_dattour.jpg" /></div>
                        </td>
                    </ItemTemplate>
                    </asp:Repeater>
                </tr>
            </table>
            <div style="width:650px" align="right">
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
        <td rowspan="2" style="padding-right:8px">
            <img src="Images/site/ver_line.jpg" alt="" />
        </td>
        <td rowspan="2" style="width:270px">
            <div align="left"><img src="Images/site/gioithieu.jpg" alt="" /></div>
            <br />
            <div class="info">
                Xin chào các bạn đến với chúng tôi. Tôi là Julie, giám đốc công ty GTS.
                <br />Công ty chúng tôi thành lập vào năm 2002 và được đổi tên vào năm 2009. Tên công ty có nghĩa là “Dịch vụ du lịch tốt”.
                <br />Chúng tôi hợp tác với các công ty du lịch quốc tế để cung cấp nhiều dịch vụ du lịch khác nhau cho khách hàng bao gồm …
            </div>
            <div style="text-align:right"><asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="~/Images/btn_doctiep.gif" /></div>
            <br />
            <div align="left"><img src="Images/site/dattour.jpg" alt="dat tour" /></div>
            <br />
            <table class="table_tour_cre">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label8" runat="server" Text="Điểm đến" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="150" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label9" runat="server" Text="Ngày khởi hành" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="150" Text="DD/MM/YYYY" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label10" runat="server" Text="Ngày trở về" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="150" Text="DD/MM/YYYY" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label11" runat="server" Text="Khách sạn" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td valign="middle">
                        <asp:TextBox ID="TextBox4" runat="server" Width="125" CssClass="textbox"></asp:TextBox>
                        <asp:Label ID="Label18" runat="server" Text="sao" CssClass="lbl_tour_cre"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label12" runat="server" Text="Người lớn" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Width="40" CssClass="textbox"></asp:TextBox>
                        &nbsp;&nbsp;<asp:Label ID="Label19" runat="server" Text="Trẻ em" CssClass="lbl_tour_cre"></asp:Label>&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox6" runat="server" Width="40" CssClass="textbox"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label13" runat="server" Text="Tên khách" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Width="150" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label14" runat="server" Text="Điện thoại" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" Width="150" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label15" runat="server" Text="Địa chỉ" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server" Width="150" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label16" runat="server" Text="Hướng dẫn viên" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server" Width="150" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label17" runat="server" Text="Xe" CssClass="lbl_tour_cre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox11" runat="server" Width="90" CssClass="textbox"></asp:TextBox>
                        <asp:Label ID="Label20" runat="server" Text="chỗ ngồi" CssClass="lbl_tour_cre"></asp:Label>                   
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        </td>
                    <td>
                         <div style="text-align:right"><asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/Images/btn_dattour.jpg" /></div>              
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <div align="left"><img src="Images/site/tour_noi_bat.jpg" alt="tour noi bat" /></div>
            <asp:DataList ID="dlProminent" runat="server" RepeatColumns="2">
            <ItemTemplate>
                <table class="table_nb" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <a href='ChiTietTour.aspx?TourId=<%# Eval("TourId")%>'>
                            <img class="img_nb" src='Images/site/TourImgs/<%# Eval("PicPath1") %>' border="0"/>
                        </a>
                    </td>
                    <td>
                        <a href='ChiTietTour.aspx?TourId=<%# Eval("TourId")%>' class="tour_header"><%# Eval("TourNm")%></a>
                        <br />
                        <div class="tour_content_nb"><%# Eval("DescReview")%></div>
                        <div style="text-align:right; padding-top: 5px; padding-right:12px"><asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/Images/btn_dattour.jpg" /></div>
                    </td>
                </tr>
                </table>
            </ItemTemplate>
            </asp:DataList>
            <div style="width:650px" align="right">
                <cc1:CollectionPager ID="CollectionPager2"
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


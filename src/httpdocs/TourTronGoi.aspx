<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TourTronGoi.aspx.cs" Inherits="TourTronGoi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<table class="table_tour_cre" style="vertical-align:top">
    <tr style="vertical-align:top">
        <td>
            <table class="tbl_tour_list">
                <tr class="tbl_tour_list_selected">
                    <td>
                        <div><asp:HyperLink ID="HyperLink1" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Provincial Tour</asp:HyperLink></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Drama Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Ski Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink4" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Sport Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink5" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Theme Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">VIP Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink7" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">DMZ& Panmunjeom Tour</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink8" runat="server" CssClass="lbl_tour_cre" NavigateUrl="TourTronGoi.aspx">Special Tour</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            <table class="table_tour_cre" style="background-image: url('images/site/tourtrongoi_bgimg.png'); background-repeat: no-repeat;padding-top: 20px; padding-left: 30px">
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="~/images/site/TourImgs/tour-tron-goi_1.jpg" Width="91px" 
                            Height="71px" />
                    </td>
                    <td>
                        <div class="tour_content">
                            <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/TourTronGoi.aspx" style="text-decoration:none"><b>Icheon Ceramics Village & Korean Folk Village Tour $120,0…</b></asp:HyperLink><br /><br />
                        Ngày1: Đến sân bay quốc tế Incheon. Quý khách lên xe khởi hành vào Seoul dùng bữa sáng với thực đơn là các món mỳ truyền thống HànQuốc Udong.Xe đưa Quý khách đến Gimpo đáp chuyến bay nội địa ra đảo Jeju...</div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <img src="images/site/tourtrongoi_sper.jpg" width="745px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/site/TourImgs/tour-tron-goi_2.jpg" Width="91px" 
                            Height="71px" />
                    </td>
                    <td>
                        <div class="tour_content">
                        <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/TourTronGoi.aspx" style="text-decoration:none"><b>World Cultural Heritage Tour $99,000</b></asp:HyperLink><br /><br />
                        Ngày1: Đến sân bay quốc tế Incheon. Quý khách lên xe khởi hành vào Seoul dùng bữa sáng với thực đơn là các món mỳ truyền thống HànQuốc Udong.Xe đưa Quý khách đến Gimpo đáp chuyến bay nội địa ra đảo Jeju...</div>                        
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <img src="images/site/tourtrongoi_sper.jpg" width="745px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/site/TourImgs/tour-tron-goi_3.jpg" Width="91px" 
                            Height="71px" />
                    </td>
                    <td>
                        <div class="tour_content">
                        <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/TourTronGoi.aspx" style="text-decoration:none"><b>Icheon Ceramics Village & Hot Springs Tour $120,000</b></asp:HyperLink><br /><br />
                        Ngày 1: Quý khách lên xe khởi hành vào Seoul dùng bữa sáng với thực đơn là món mỳ truyền thống Hàn Quốc Udong. Sau đó, xe đưa Quý khách đi thăm cung điện Hoàng Gia Gyeongbok và bảo tàng dân tộc Quốc gia....
                        </div>                      
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <img src="images/site/tourtrongoi_sper.jpg" width="745px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images/site/TourImgs/tour-tron-goi_4.jpg" Width="91px" 
                            Height="71px" />
                    </td>
                    <td>
                        <div class="tour_content">
                        <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/TourTronGoi.aspx" style="text-decoration:none"><b>Gangnam Tour - Afternoon Tour $10,000</b></asp:HyperLink><br /><br />
                        Ngày1: Đến sân bay quốc tế Incheon. Quý khách lên xe khởi hành vào Seoul dùng bữa sáng với thực đơn là các món mỳ truyền thống HànQuốc Udong.Xe đưa Quý khách đến Gimpo đáp chuyến bay nội địa ra đảo Jeju...</div>                        
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
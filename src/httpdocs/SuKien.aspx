<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SuKien.aspx.cs" Inherits="SuKien" %>

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
            <table class="table_tour_cre" style="background-image: url('images/site/tourtrongoi_bgimg.png'); background-repeat: no-repeat;padding-top: 20px; padding-left: 30px">
                <tr style="width: 500px">
                    <td>
                        Ngày Tháng
                    </td>
                    <td>
                        Sự kiện
                    </td>
                    <td>
                        Địa điểm
                    </td>
                </tr>
                <tr>
                    <td>
                        20/09/2011
                    </td>
                    <td>
                        Special Seoul
                    </td>
                    <td>
                        Seoul
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>


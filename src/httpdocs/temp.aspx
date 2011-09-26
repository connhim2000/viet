<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temp.aspx.cs" Inherits="temp" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Css/StyleSheet.css" type="text/css" charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <table class="table">
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="menu" 
                        PostBackUrl="~/Default.aspx">TRANG CHỦ</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="menu" 
                        PostBackUrl="~/GioiThieu.aspx">GIỚI THIỆU</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="menu">TOUR TRỌN GÓI</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton4" runat="server" CssClass="menu">TOUR TỰ CHỌN</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton5" runat="server" CssClass="menu">ĐỊA ĐIỂM DU LỊCH</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton6" runat="server" CssClass="menu">KHÁCH SẠN</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton7" runat="server" CssClass="menu">SỰ KIỆN</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton8" runat="server" CssClass="menu" 
                        PostBackUrl="~/DatTour.aspx">ĐẶT TOUR</asp:LinkButton></td>
                <td>
                    <img src="Images/spar.gif" />
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton9" runat="server" CssClass="menu" 
                        PostBackUrl="~/LienHe.aspx">LIÊN HỆ</asp:LinkButton></td>
            </tr>
        </table>
    </div>
    tessdfastsdfsdaddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd<br />
    ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd<br />
    ddssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss<br />
    <!--for menu -->
    <asp:HoverMenuExtender ID="hme2" runat="Server"
    TargetControlID="LinkButton3"
    PopupControlID="PopupMenu"
    HoverCssClass="popupHover"
    PopupPosition="Bottom"
    OffsetX="0"
    OffsetY="0"
    PopDelay="50">
    
    </asp:HoverMenuExtender>
    </form>
    <table runat="server" id="PopupMenu" class="opacity">
        <tr>
            <td>
                test1hehehehehhhee
            </td>
        </tr>
        <tr>
            <td>
                test2
            </td>
        </tr>
        <tr>
            <td>
                test3
            </td>
        </tr>
    </table>
    <!--<Animations>
        <OnShow>
            <Sequence>
                <HideAction Visible="true" />
                <FadeIn Duration="0.5" Fps="20" />
            </Sequence>
        </OnShow>
        <OnHide>
            <Sequence>
                <FadeOut Duration=".25" Fps="20" />
                <HideAction Visible="false" />
            </Sequence>
        </OnHide>
    </Animations>-->
</body>
</html>

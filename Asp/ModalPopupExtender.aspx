<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBranch.aspx.cs" Inherits="AddBranch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
 .modalBackground
{
    background-color:Gray;
    filter:alpha(opacity=50);
    opacity:0.7;
}
.pnlBackGround
{
    position:fixed;
    top:10%;
    left:10px;
    width:300px;
    height:125px;
    text-align:center;
    background-color:White;
    border:solid 3px black;
    z-index:20;
}
    
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            <div id="IMGDIV" align="center" valign="middle" runat="server" style="position: absolute;
                left: 45%; top: 45%; visibility: visible; vertical-align: middle; z-index:10">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/processing_icon.gif" Width="50"
                    Height="50" />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="Update1" runat="server">
    <ContentTemplate>
    <asp:Button ID="BtnOPenPopup" runat="server" Text="OpenPopup" 
            onclick="BtnOPenPopup_Click" />
             <asp:ModalPopupExtender BackgroundCssClass="modalBackground" BehaviorID="BehaviorModalSave"  ID="ModalPopupExtender1"  TargetControlID="btnOpen" DropShadow="true" OkControlID="btnCancel" PopupControlID="PanelAddBranch" runat="server"></asp:ModalPopupExtender>
    <asp:Button ID="btnOpen" style="display:none;" runat="server" Text="Open" />
         <asp:Panel  CssClass="pnlBackGround"  ID="PanelAddBranch" BackColor="aqua" runat="server">
            <table>
                <tr>
                    <td>Branch Name</td>
                    <td><asp:TextBox ID="txtBranchName" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="lblOne" runat="server" ></asp:Label></td>
                </tr>
                 <tr>
                    <td>Branch Head</td>
                    <td><asp:TextBox ID="txtBranchHead" runat="server" ></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnOk" runat="server" Text="Ok" onclick="btnOk_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                    </td>
                    <td></td>
                </tr>
            </table>
         </asp:Panel>  
          <asp:ScriptManager ID="ScriptManager1" runat="server">
             </asp:ScriptManager>
          
             
        <%--<ajaxToolkit:AnimationExtender  ID="AnimationExtender1" TargetControlID="btnOpen" runat="server">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="PanelAddBranch" 
                    Duration="0.3" Fps="25">
                    <FadeIn />                                        
                    <Move Horizontal="500" Vertical="250"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>

        </ajaxToolkit:AnimationExtender>--%>
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>

-----------------------------------------------
public partial class AddBranch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        this.ModalPopupExtender1.Show();
        lblOne.Text = "hi";
        System.Threading.Thread.Sleep(10000);

       
    }
    protected void BtnOPenPopup_Click(object sender, EventArgs e)
    {
        this.ModalPopupExtender1.Show();
    }
}

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
}
    
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnOpen" runat="server" Text="Open" />
         <asp:Panel  CssClass="pnlBackGround" ID="PanelAddBranch" BackColor="aqua" runat="server">
            <table>
                <tr>
                    <td>Branch Name</td>
                    <td><asp:TextBox ID="txtBranchName" runat="server"></asp:TextBox></td>
                    <td></td>
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
          
             <asp:ModalPopupExtender BackgroundCssClass="modalBackground"  ID="ModalPopupExtender1"  TargetControlID="btnOpen" DropShadow="true" OkControlID="btnCancel" PopupControlID="PanelAddBranch" runat="server"></asp:ModalPopupExtender> 
        <ajaxToolkit:AnimationExtender  ID="AnimationExtender1" TargetControlID="btnOpen" runat="server">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="PanelAddBranch" 
                    Duration="0.3" Fps="25">
                    <FadeIn />                                        
                    <Move Horizontal="500" Vertical="250"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>

        </ajaxToolkit:AnimationExtender>
    </div>
    </form>
</body>
</html>

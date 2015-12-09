<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DailyReport.aspx.cs" Inherits="DailyReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    .Grid {background-color: #fff; margin: 5px 0 10px 0; border: solid 1px #525252; border-collapse:collapse; font-family:Calibri; color: #474747;}
.Grid td {
      padding: 2px;
      border: solid 1px #c1c1c1; }
.Grid th  {
      padding : 4px 2px;
      color: #fff;
      background: #363670 url(Images/grid-header.png) repeat-x top;
      border-left: solid 1px #525252;
      font-size: 0.9em; }
.Grid .alt {
      background: #fcfcfc url(Images/grid-alt.png) repeat-x top; }
.Grid .pgr {background: #363670 url(Images/grid-pgr.png) repeat-x top; }
.Grid .pgr table { margin: 3px 0; }
.Grid .pgr td { border-width: 0; padding: 0 6px; border-left: solid 1px #666; font-weight: bold; color: #fff; line-height: 12px; }  
.Grid .pgr a { color: Gray; text-decoration: none; }
.Grid .pgr a:hover { color: #000; text-decoration: none; }
- See more at: http://www.dotnetfox.com/articles/gridview-custom-css-style-example-in-Asp-Net-1088.aspx#sthash.wXdQkGDX.dpuf
    
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div><h2>Daily Report Practise</h2></div>
        <asp:GridView AutoGenerateColumns="false" CssClass="Grid"                    
                      AlternatingRowStyle-CssClass="alt"
                      PagerStyle-CssClass="pgr" ShowFooter="true" runat="server" >
        <Columns>
            <asp:TemplateField HeaderText="Vechile Number" >
                <ItemTemplate>
                        <asp:Label ID="lblVechileNo" runat="server" Text='<%# Eval("VechileNo") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtVechileNo" runat="server" Text='<%# Eval("VechileNo") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtvechileInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hospital Name" >
                <ItemTemplate>
                        <asp:Label ID="lblHospitalName" runat="server" Text='<%# Eval("HospitalName") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlHospitalName" runat="server"></asp:DropDownList>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList ID="ddlHospitalNameInsert" runat="server"></asp:DropDownList>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Incharge Name" >
                <ItemTemplate>
                        <asp:Label ID="lblInchargeName" runat="server" Text='<%# Eval("InchargeName") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtInchargeName" runat="server" Text='<%# Eval("InchargeName") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtInchargeNameInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Inc Travel Cost" >
                <ItemTemplate>
                        <asp:Label ID="lblTravelCost" runat="server" Text='<%# Eval("TravelCost") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtIncTravelCost" runat="server" Text='<%# Eval("TravelCost") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtIncTravelCostInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Inc Food Cost" >
                <ItemTemplate>
                        <asp:Label ID="lblFoodCost" runat="server" Text='<%# Eval("FoodCost") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtFoodCost" runat="server" Text='<%# Eval("FoodCost") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtFoodCostInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mobile Bill" >
                <ItemTemplate>
                        <asp:Label ID="lblMobileBill" runat="server" Text='<%# Eval("MobileBill") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtMobileBill" runat="server" Text='<%# Eval("MobileBill") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtMobileBillInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Administrative Charge" >
                <ItemTemplate>
                        <asp:Label ID="lblAdministrativeCharge" runat="server" Text='<%# Eval("AdministrativeCharge") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtAdministrativeCharge" runat="server" Text='<%# Eval("AdministrativeCharge") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtAdministrativeChargeInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remarks" >
                <ItemTemplate>
                        <asp:Label ID="lblRemarks" runat="server" Text='<%# Eval("Remarks") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtRemarksEdit" runat="server" Text='<%# Eval("Remarks") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtRemarksInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Other Charges" >
                <ItemTemplate>
                        <asp:Label ID="lblRemarks" runat="server" Text='<%# Eval("OtherCharges") %>'></asp:Label>
                
                </ItemTemplate >
                <EditItemTemplate>
                    <asp:TextBox ID="txtOtherCharges" runat="server" Text='<%# Eval("OtherCharges") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtOtherChargesInsert" runat="server"></asp:TextBox>
                               </FooterTemplate>
            
            </asp:TemplateField>
                
        
        </Columns>
        
        
        
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridDownloadColumnWeb</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" ClientInstanceName="grid"
            KeyFieldName="ProductID" AutoGenerateColumns="False">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="ProductID" VisibleIndex="0">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="UnitsOnOrder" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataColumn Caption="Doc" VisibleIndex="4">
                    <DataItemTemplate>
                        <dx:ASPxButton ID="ASPxButton1" runat="server" OnInit="ASPxButton1_Init" 
                            AutoPostBack="False" RenderMode="Link" Text="Download">
                           <Image IconID="actions_download_16x16" />
                        </dx:ASPxButton>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
            </Columns>
        </dx:ASPxGridView>
    </div>
    </form>
</body>
</html>

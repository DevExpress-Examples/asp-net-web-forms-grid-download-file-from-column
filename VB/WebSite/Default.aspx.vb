Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		ASPxGridView1.DataSource = Product.GetData()
		ASPxGridView1.DataBind()
	End Sub

	Protected Sub ASPxButton1_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim button As ASPxButton = CType(sender, ASPxButton)
		Dim container As GridViewDataItemTemplateContainer = CType(button.NamingContainer, GridViewDataItemTemplateContainer)

		If FileExists(container.KeyValue) Then
			button.ClientSideEvents.Click = String.Format("function(s, e) {{ window.location = 'FileDownloadHandler.ashx?id={0}'; }}", container.KeyValue)
		Else
			button.ClientEnabled = False
			'button.ClientSideEvents.Click = string.Format("function(s, e) {{ alert('There is no file for key {0}'); }}", container.KeyValue);
		End If
	End Sub

	Private Function FileExists(ByVal key As Object) As Boolean
		Return Not String.IsNullOrEmpty(Product.GetData().First(Function(p) p.ProductID.Equals(key)).ImagePath)
	End Function
End Class
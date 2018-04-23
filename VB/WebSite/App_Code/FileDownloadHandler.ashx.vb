Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System

Public Class FileDownloadHandler
	Implements IHttpHandler
	Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
		Dim id As String = context.Request("id")
		Dim content() As Byte = GetFileContentByKey(context, id)

		ExportToResponse(context, content, "image_" & id, "jpg", False)
	End Sub

	Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
		Get
			Return False
		End Get
	End Property

	Private Function GetFileContentByKey(ByVal context As HttpContext, ByVal key As Object) As Byte()
		Dim relativePath As String = Product.GetData().First(Function(p) p.ProductID.Equals(Convert.ToInt32(key))).ImagePath

		Return File.ReadAllBytes(context.Server.MapPath(relativePath))
	End Function

	Public Sub ExportToResponse(ByVal context As HttpContext, ByVal content() As Byte, ByVal fileName As String, ByVal fileType As String, ByVal inline As Boolean)
		context.Response.Clear()
		context.Response.ContentType = "application/" & fileType
		If inline Then
			context.Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}.{2}","Inline", fileName, fileType))
		Else
			context.Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}.{2}","Attachment", fileName, fileType))
		End If
		context.Response.AddHeader("Content-Length", content.Length.ToString())
		'Response.ContentEncoding = System.Text.Encoding.Default;
		context.Response.BinaryWrite(content)
		context.Response.Flush()
		context.Response.Close()
		context.Response.End()
	End Sub
End Class
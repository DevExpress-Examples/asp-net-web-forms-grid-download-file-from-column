using System.IO;
using System.Linq;
using System.Web;
using System;

public class FileDownloadHandler : IHttpHandler {
    public void ProcessRequest(HttpContext context) {
        string id = context.Request["id"];
        byte[] content = GetFileContentByKey(context, id);

        ExportToResponse(context, content, "image_" + id, "jpg", false);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

    private byte[] GetFileContentByKey(HttpContext context, object key) {
        string relativePath = Product.GetData().First(p => p.ProductID.Equals(Convert.ToInt32(key))).ImagePath;

        return File.ReadAllBytes(context.Server.MapPath(relativePath));
    }

    public void ExportToResponse(HttpContext context, byte[] content, string fileName, string fileType, bool inline) {
        context.Response.Clear();
        context.Response.ContentType = "application/" + fileType;
        context.Response.AddHeader("Content-Disposition", string.Format("{0}; filename={1}.{2}", inline ? "Inline" : "Attachment",  fileName, fileType));
        context.Response.AddHeader("Content-Length", content.Length.ToString());
        //Response.ContentEncoding = System.Text.Encoding.Default;
        context.Response.BinaryWrite(content);
        context.Response.Flush();
        context.Response.Close();
        context.Response.End();
    }
}
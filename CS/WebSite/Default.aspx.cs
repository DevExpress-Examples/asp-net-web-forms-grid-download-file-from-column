using System;
using System.Linq;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        ASPxGridView1.DataSource = Product.GetData();
        ASPxGridView1.DataBind();
    }

    protected void ASPxButton1_Init(object sender, EventArgs e) {
        ASPxButton button = (ASPxButton)sender;
        GridViewDataItemTemplateContainer container = (GridViewDataItemTemplateContainer)button.NamingContainer;

        if (FileExists(container.KeyValue)) {
            button.ClientSideEvents.Click = string.Format("function(s, e) {{ window.location = 'FileDownloadHandler.ashx?id={0}'; }}", container.KeyValue);
        }
        else {
            button.ClientEnabled = false;
            //button.ClientSideEvents.Click = string.Format("function(s, e) {{ alert('There is no file for key {0}'); }}", container.KeyValue);
        }
    }

    private bool FileExists(object key) {
        return !string.IsNullOrEmpty(Product.GetData().First(p => p.ProductID.Equals(key)).ImagePath);
    }
}
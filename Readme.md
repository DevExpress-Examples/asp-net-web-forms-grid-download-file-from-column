# How to download files from a specific ASPxGridView's column


<p>This example illustrates how to create a column whose cells are rendered as links with icons. Once the link is clicked, the file that corresponds to the current row starts downloading. Here is a downloading column's markup:<br />
</p>

```aspx
                <dx:GridViewDataColumn Caption="Doc" VisibleIndex="5">
                    <DataItemTemplate>
                        <dx:ASPxButton ID="ASPxButton1" runat="server" OnInit="ASPxButton1_Init" 
                            AutoPostBack="False" RenderMode="Link" Text="Download">
                           <Image IconID="actions_download_16x16" />
                        </dx:ASPxButton>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>

```

<p>Note that we are using the common <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxGridViewGridViewDataColumntopic"><u>GridViewDataColumn Class</u></a> with the <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsASPxButtontopic"><u>ASPxButton Class</u></a> which <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsASPxButton_RenderModetopic"><u>ASPxButton.RenderMode Property</u></a> has the <strong>Link</strong> value (see also: <a href="https://www.devexpress.com/Support/Center/p/KA18872">ASPxButton - How to disable default appearance starting with 13.2 (display only an image)</a>). This way, we can display an image. If you need only a link, it is sufficient to use the <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxGridViewGridViewDataHyperLinkColumntopic"><u>GridViewDataHyperLinkColumn Class</u></a>. The ASPxButton's client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsScriptsASPxClientButton_Clicktopic"><u>Click</u></a> event code is calculated dynamically in the server-side Init event handler. Here we redirect a web browser to the <strong>FileDownloadHandler.asxh</strong> handler (e.g., see <a href="http://www.hanselman.com/blog/ASPNETFuturesGeneratingDynamicImagesWithHttpHandlersGetsEasier.aspx"><u>ASP.NET Futures - Generating Dynamic Images with HttpHandlers gets Easier - Scott Hanselman</u></a>) to obtain the corresponding file by a row key value and send this file to the browser.</p><p><strong>NOTE:</strong> If you are only interested in end-user capabilities for file uploading and downloading, consider using our <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxFileManagerASPxFileManagertopic"><u>ASPxFileManager Class</u></a> (e.g., see <a href="http://documentation.devexpress.com/#AspNet/CustomDocument9837"><u>File Download</u></a>).</p>

<br/>



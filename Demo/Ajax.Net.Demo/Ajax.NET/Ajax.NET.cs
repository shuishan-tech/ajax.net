using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using AjaxPro;

namespace Ajax.Net.Demo
{
    [ToolboxItemAttribute(false)]
    [AjaxNamespace("Ajax.Net.Demo")]
    public class AjaxWebPart : WebPart
    {
        // 更改可视 Web 部件项目项后，Visual Studio 可能会自动更新此路径。
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/15/Ajax.Net.Demo/Ajax.NET/Ajax.NETUserControl.ascx";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AjaxPro.Utility.RegisterTypeForAjax(this.GetType());
        }
        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

        [AjaxMethod]
        public string GetSPContext()
        {
            string result = "{{siteTitle: '{0}', siteId: '{1}', webTitle: '{2}', webiId: '{3}', listTitle: '{4}' listId: '{5}'}}";

            result = string.Format(result,
                SPContext.Current.Site.PortalName,
                SPContext.Current.Site.ID,
                SPContext.Current.Web.Title,
                SPContext.Current.Web.ID,
                SPContext.Current.List.Title,
                SPContext.Current.List.ID
                );

            return result;
        }
    }
}

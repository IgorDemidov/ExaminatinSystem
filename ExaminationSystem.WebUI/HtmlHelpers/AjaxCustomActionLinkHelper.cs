using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace ExaminationSystem.WebUI.HtmlHelpers
{
    public static class AjaxCustomActionLinkHelper
    {
        public static MvcHtmlString CustomActionLink(this AjaxHelper ajax,
            string linkText,
            string actionName,
            string controllerName,
          //  RouteValueDictionary routeValues=null, 
            object routeValues=null,
            object htmlAttributes = null,
            string updateTargetId = "content",
            string loadingElementId = "loading-indicator"
            )
        {
            //TagBuilder tag = new TagBuilder("a");
            //tag.MergeAttribute("data-ajax","true");
            //tag.MergeAttribute("data-ajax-mode", "replace");
            //tag.MergeAttribute("data-ajax-update", updateTargetId);
            //tag.MergeAttribute("data-ajax-loading", loadingElementId);
            //string url = UrlHelper.GenerateUrl("Default", actionName, controllerName, routeValues, html.RouteCollection,
            //html.ViewContext.RequestContext, true);//RouteTable.Routes
            //tag.MergeAttribute("href", url);
            //tag.InnerHtml = linkText;
            //return new MvcHtmlString(tag.ToString());
            AjaxOptions ajaxOptions = new AjaxOptions()
            {
                LoadingElementId = loadingElementId,
                UpdateTargetId = updateTargetId
            };
           
            AjaxHelper ajaxHelper = new AjaxHelper(ajax.ViewContext, ajax.ViewDataContainer);
            return ajaxHelper.ActionLink(linkText, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);

            //var ajaxAttributes = new 
            //{
            //    "data-ajax" = "true",
            //    data-ajax-mode = "replace",
            //    data-ajax-update = updateTargetId,
            //    data-ajax-loading = loadingElementId
            //};

            //return html.ActionLink(linkText, actionName, controllerName, routeValues).;




        }
    }
}
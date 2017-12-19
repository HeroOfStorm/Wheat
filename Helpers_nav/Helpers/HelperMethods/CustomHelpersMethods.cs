using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers.Models;
using System.Text;
using System.Web.Mvc.Ajax;

namespace Helpers.HelperMethods
{
    public static class CustomHelpersMethods
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
            PageLinksModel pages, Func<int,string> func)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i<=pages.CountPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", func(i));
                tag.InnerHtml = i.ToString();

                if (i == pages.CurrentPage)
                    tag.AddCssClass("btn btn-success");
                else
                    tag.AddCssClass("btn btn-outline-success");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }


        public static MvcHtmlString PageLinks(this AjaxHelper html,
           PageLinksModel pages, Func<int, string> func, string target)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= pages.CountPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", func(i));
                tag.InnerHtml = i.ToString();

           
                AjaxOptions options = new AjaxOptions();
                options.UpdateTargetId = target;
                tag.MergeAttributes(options.ToUnobtrusiveHtmlAttributes());

             
                    tag.AddCssClass("btn btn-success");
             
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}
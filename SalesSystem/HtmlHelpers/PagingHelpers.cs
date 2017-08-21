using System;
using System.Web.Mvc;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();

            for (int pageNo = 1; pageNo <= pagingInfo.TotalPages; pageNo++)
            {
                TagBuilder tag = new TagBuilder("a");
                
                tag.MergeAttribute("href", pageUrl(pageNo));
                tag.InnerHtml = pageNo.ToString();

                if (pageNo == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }
            
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Extensions;

namespace WebApplication1.Infrastructure
{
    public static class HtmlHelperExt
    {
        public static MvcHtmlString UlListHtmlString(this HtmlHelper htmlHelper, IEnumerable<string> itemList, object htmlAttributes)
        {
            if (itemList == null)
            {
                throw new ArgumentException("itemList is null", "itemList");
            }
            StringBuilder liBuilder = new StringBuilder();
            itemList.ForEach(m =>
            {
                liBuilder.Append("<li>" + HttpUtility.HtmlEncode(m) + "</li>");
            });
            TagBuilder ulTagBuilder = new TagBuilder("ul")
            {
                InnerHtml = liBuilder.ToString()
            };
            ulTagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return new MvcHtmlString(ulTagBuilder.ToString(TagRenderMode.Normal));
        }
    }
}
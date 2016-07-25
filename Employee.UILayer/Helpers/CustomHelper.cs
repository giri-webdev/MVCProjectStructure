using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.UILayer.Helpers
{
    public static class CustomHelper
    {
        public static MvcHtmlString ListColors(this HtmlHelper htmlHelper,string[] colors)
        {
            var ul = new TagBuilder("ul");

            foreach(var color in colors)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(color);
                ul.InnerHtml += li.ToString();
            }

            return new MvcHtmlString(ul.ToString());
        }
    }
}
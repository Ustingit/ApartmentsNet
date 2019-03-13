using System.Web.Mvc;

namespace Apartments.Helpers
{
    public static class ImageHelpers
    {
        public static string GetImageUrl(string shortId, string fileName)
        {
            string hardcodedUrl = "~/Images/kvartirant/";

            return $"{hardcodedUrl}{shortId}" + "/" + fileName;
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder img = new TagBuilder("img");
            img.MergeAttribute("src", src);
            img.MergeAttribute("alt", alt);

            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string shortId, string fileName, string alt)
        {
            TagBuilder img = new TagBuilder("img");
            img.MergeAttribute("src", GetImageUrl(shortId, fileName));
            img.MergeAttribute("alt", alt);

            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string path, string shortId, string fileName, string alt)
        {
            string fullPath = path + shortId + "/" + fileName;

            TagBuilder img = new TagBuilder("img");
            img.MergeAttribute("src", fullPath);
            img.MergeAttribute("alt", alt);

            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));
        }
    }
}
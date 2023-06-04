using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Extensions
{
    public static class HtmlHelpers
    {
        public static string IsSelected(this IHtmlHelper html, string controller = null, string cssClass = null)
        {
            if (string.IsNullOrWhiteSpace(cssClass))
            {
                cssClass = "active bg-gradient-primary";
            }

            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrWhiteSpace(controller))
            {
                controller = currentController;
            }

            return controller.Equals(currentController, StringComparison.OrdinalIgnoreCase) ? cssClass : string.Empty;
        }
    }
}

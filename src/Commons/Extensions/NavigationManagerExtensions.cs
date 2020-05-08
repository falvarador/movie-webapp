namespace MovieWeb.WebApp.Common
{
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class NavigationManagerExtension
    {
        public static Dictionary<string, string> GetQueryStrings(this NavigationManager navigationManager, string url)
        {
            if (string.IsNullOrWhiteSpace(url) || !url.Contains("?") || url.Substring(url.Length - 1) == "?")
            {
                return null;
            }

            var queryStrings = url.Split(new string[] { "?" }, StringSplitOptions.None)[1];
            Dictionary<string, string> queryStringValues = queryStrings.Split('&')
                                                            .ToDictionary(c => c.Split('=')[0],
                                                                    c => Uri.UnescapeDataString(c.Split('=')[1]));

            return queryStringValues;
        }
    }
}

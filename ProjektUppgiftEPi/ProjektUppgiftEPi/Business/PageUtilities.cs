using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektUppgiftEPi.Business
{
    public static class PageUtilities
    {
        public static bool HasChildren(this ContentReference page)
        {
            return ServiceLocator.Current
                .GetInstance<IContentLoader>()
                .GetChildren<PageData>(page)
                .Any(x => x.VisibleInMenu);
        }

        public static bool IsAncestorOf(this ContentReference parent, ContentReference child)
        {
            var ancestors = ServiceLocator.Current
                .GetInstance<IContentLoader>()
                .GetAncestors(child);

            return ancestors.Any(x => x.ContentLink.CompareToIgnoreWorkID(parent));
        }

        public static string Truncate(this string s, int length)
        {
            if(s == null)
                return string.Empty;

            return s.Length > length ? s.Substring(0, length) : s;
        }

        public static int ToInt(this string s, int defaultValue = 0)
        {
            if (s == null) return defaultValue;

            int i;
            return int.TryParse(s, out i) ? i : defaultValue;
        }
    }
}
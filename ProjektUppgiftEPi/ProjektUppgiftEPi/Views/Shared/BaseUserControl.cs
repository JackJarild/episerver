using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace ProjektUppgiftEPi.Views.Shared
{
    public class BaseUserControl : EPiServer.UserControlBase
    {
        public string GetUrl(ContentReference content)
        {
            return ServiceLocator
                .Current
                .GetInstance<UrlResolver>()
                .GetUrl(content);
        }
    }
}
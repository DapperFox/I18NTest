using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using i18n;


namespace NuviInternationalizationTest
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
            
			// Change from the default of 'en'.
			//i18n.LocalizedApplication.Current.DefaultLanguage = "de";

			// Change from the of temporary redirects during URL localization
			i18n.LocalizedApplication.Current.PermanentRedirects = true;

			// This line can be used to disable URL Localization.
			i18n.LocalizedApplication.Current.EarlyUrlLocalizerService = null;

			// Change the URL localization scheme from Scheme1.
			i18n.UrlLocalizer.UrlLocalizationScheme = i18n.UrlLocalizationScheme.Scheme2;

			// Blacklist certain URLs from being 'localized'.
			i18n.UrlLocalizer.IncomingUrlFilters += delegate(Uri url)
			{
				if (url.LocalPath.EndsWith("sitemap.xml", StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
				return true;
			};

			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			AuthConfig.RegisterAuth();
		}
	}
}
using System.Web;
using System.Web.Optimization;

namespace $safeprojectname$
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/Content/themes/base/js/vendor/").Include(
						"~/Content/themes/base/js/vendor/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/Content/themes/base/js/vendor/").Include(
						"~/Content/themes/base/js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"));

			bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
						"~/Content/themes/base/css/main.css",
						"~/Content/themes/base/css/normalize.min.css"));
		}
	}
}
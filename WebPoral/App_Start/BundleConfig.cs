using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebPoral.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle stylesbundle = new StyleBundle("~/Styles/css");
            stylesbundle.Include("~/styles/bootstrap.min.css",
                                "~/styles/font-awesome.min.css",
                                "~/styles/custom.css");

            ScriptBundle thirdPartyScripts = new ScriptBundle("~/Scripts/ThirdParty");
            thirdPartyScripts.Include("~/Scripts/jquery.min.js",
                                "~/Scripts/bootstrap.min.js",
                                "~/Scripts/custom.min.js");

            ScriptBundle chartjs = new ScriptBundle("~/Scripts/Charts");
            chartjs.Include("~/Scripts/Chart.bundle.min.js");
            

            bundles.Add(stylesbundle);
            bundles.Add(thirdPartyScripts);
            bundles.Add(chartjs);


            BundleTable.EnableOptimizations = true;
        }
    }
}
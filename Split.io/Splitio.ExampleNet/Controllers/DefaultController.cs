using Splitio.Services.Client.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Splitio.ExampleNet.Controllers
{
    public class DefaultController : Controller
    {
        SelfRefreshingClient sdk;
        //
        // GET: /Automation/

        public ActionResult Index()
        {
            sdk = HttpContext.Application["sdk"] as SelfRefreshingClient;

            // CHANGE THIS: Copy and paste the feature name from Split UI
            String featureName = "<feature name here>";
            
            // Change this to represent your user or account id. (usually a dynamic value)
            String userKey = "userId-1";

            var result = sdk.GetTreatment(userKey, featureName);

            return Content(String.Format(@"<html>
                                                <body>
                                                    <p data-tid='test-value'>{0}</p>
                                                </body>
                                           </html>", result));
        }
    }
}

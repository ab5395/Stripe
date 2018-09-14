using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace StripePaymentExample.Controllers
{
    [Produces("application/json")]
    [Route("api/StripePayment")]
    public class StripePaymentController : Controller
    {
        [HttpGet]
        [Route("CreateCharge")]
        public IActionResult CreateCharge()
        {
            return View();
        }

        [HttpGet]
        [Route("GetCharge")]
        public IActionResult GetCharge(string id)
        {
            var data = Request.QueryString;
            StripeConfiguration.SetApiKey("sk_test_6CMUpzy8QkVPxssGkgV5Jc7k");

            var options = new StripeChargeCreateOptions
            {
                Amount = 100,
                Currency = "USD",
                Description = "Example charge",
                SourceTokenOrExistingSourceId = id,
            };
            var service = new StripeChargeService();
            StripeCharge charge = service.Create(options);
            return Json(charge);
        }

        [HttpPost]
        [Route("GetWebHook")]
        public IActionResult GetWeebHook()
        {
            var json = new StreamReader(HttpContext.Request.Body).ReadToEnd();

            try
            {
                var stripeEvent = StripeEventUtility.ConstructEvent(json,
                    Request.Headers["Stripe-Signature"], "whsec_vEw1qUwNaH1SyClLDYYZqqSlLWiBHtU1");

                // Do something with event

            }
            catch (StripeException e)
            {
                return BadRequest();
            }
            return Json(true);

        }





    }

    public class JsonResponseHelper
    {
        private bool v1;
        private string v2;
        private StripeCharge charge;

        public JsonResponseHelper(bool v1, string v2, StripeCharge charge)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.charge = charge;
        }

        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
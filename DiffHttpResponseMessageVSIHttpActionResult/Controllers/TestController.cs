using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiffHttpResponseMessageVSIHttpActionResult.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var result = "Action Method with HttpResponseMessage";

            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,result);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound,"Not Found");
        }
        public IHttpActionResult Get(int id) {
            var result = "Action Method with iHttpActionResult";

            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();

        }
    }
}

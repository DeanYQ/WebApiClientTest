using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiHttpTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("put")]
    public class PutController : ApiController
    {
        [Route("Ok")]
        [HttpPut]
        public IHttpActionResult PutOK()
        {
            return Ok("Return OK");
        }

        [Route("BadRequest")]
        [HttpPut]
        public IHttpActionResult PutBadRequest()
        {
            return BadRequest("Return bad request");
        }

        [Route("InternalServerError")]
        [HttpPut]
        public IHttpActionResult PutInternalServerError()
        {
            return InternalServerError();
        }

        [Route("Exception")]
        [HttpPut]
        public IHttpActionResult PutException()
        {
            return InternalServerError(new Exception("Return Empty Exception"));
        }

        [Route("StatusCode")]
        [HttpPut]
        public IHttpActionResult PutStatusCode()
        {
            return StatusCode(System.Net.HttpStatusCode.Accepted);
        }

        [Route("Unauthorized")]
        [HttpPut]
        public IHttpActionResult PutUnauthorized()
        {
            return Unauthorized();
        }

        [Route("Json")]
        [HttpPut]
        public IHttpActionResult PutJson(dynamic json)
        {
            return Json<dynamic>(json);
        }
    }
}

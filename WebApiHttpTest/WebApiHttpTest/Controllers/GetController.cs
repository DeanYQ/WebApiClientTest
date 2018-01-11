using System;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiHttpTest.Common;

namespace WebApiHttpTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("get")]
    public class GetController : ApiController
    {
        [Route("Ok")]
        [HttpGet]
        public IHttpActionResult GetOK()
        {
            return Ok("Return OK");
        }

        [Route("BadRequest")]
        [HttpGet]
        public IHttpActionResult GetBadRequest()
        {
            return BadRequest("Return bad request");
        }

        [Route("InternalServerError")]
        [HttpGet]
        public IHttpActionResult GetInternalServerError()
        {
            return InternalServerError();
        }

        [Route("Exception")]
        [HttpGet]
        public IHttpActionResult GetException()
        {
            return InternalServerError(new Exception("Return Empty Exception"));
        }

        [Route("StatusCode")]
        [HttpGet]
        public IHttpActionResult GetStatusCode()
        {
            return StatusCode(System.Net.HttpStatusCode.Accepted);
        }

        [Route("Unauthorized")]
        [HttpGet]
        public IHttpActionResult GetUnauthorized()
        {
            return Unauthorized();
        }

        [Route("Json")]
        [HttpGet]
        public IHttpActionResult GetJson()
        {
            return Json<Person>(new Person { Name = "testName", Age = 13 });
        }
    }
}

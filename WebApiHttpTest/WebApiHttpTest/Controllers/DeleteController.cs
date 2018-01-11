using System;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiHttpTest.Common;

namespace WebApiHttpTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("delete")]
    public class DeleteController : ApiController
    {
        [Route("Ok")]
        [HttpDelete]
        public IHttpActionResult DeleteOK()
        {
            return Ok("Return OK");
        }

        [Route("BadRequest")]
        [HttpDelete]
        public IHttpActionResult DeleteBadRequest()
        {
            return BadRequest("Return bad request");
        }

        [Route("InternalServerError")]
        [HttpDelete]
        public IHttpActionResult DeleteInternalServerError()
        {
            return InternalServerError();
        }

        [Route("Exception")]
        [HttpDelete]
        public IHttpActionResult DeleteException()
        {
            return InternalServerError(new Exception("Return Empty Exception"));
        }

        [Route("StatusCode")]
        [HttpDelete]
        public IHttpActionResult DeleteStatusCode()
        {
            return StatusCode(System.Net.HttpStatusCode.Accepted);
        }

        [Route("Unauthorized")]
        [HttpDelete]
        public IHttpActionResult DeleteUnauthorized()
        {
            return Unauthorized();
        }

        [Route("Json")]
        [HttpDelete]
        public IHttpActionResult DeleteJson()
        {
            return Json<Person>(new Person { Name = "testName", Age = 13 });
        }
    }
}

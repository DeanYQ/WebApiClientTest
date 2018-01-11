using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiHttpTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("post")]
    public class PostController : ApiController
    {
        [Route("Ok")]
        [HttpPost]
        public IHttpActionResult PostOK()
        {
            return Ok("Return OK");
        }

        [Route("BadRequest")]
        [HttpPost]
        public IHttpActionResult PostBadRequest()
        {
            return BadRequest("Return bad request");
        }

        [Route("InternalServerError")]
        [HttpPost]
        public IHttpActionResult PostInternalServerError()
        {
            return InternalServerError();
        }

        [Route("Exception")]
        [HttpPost]
        public IHttpActionResult PostException()
        {
            return InternalServerError(new Exception("Return Empty Exception"));
        }

        [Route("StatusCode")]
        [HttpPost]
        public IHttpActionResult PostStatusCode()
        {
            return StatusCode(System.Net.HttpStatusCode.Accepted);
        }

        [Route("Unauthorized")]
        [HttpPost]
        public IHttpActionResult PostUnauthorized()
        {
            return Unauthorized();
        }

        [Route("Json")]
        [HttpPost]
        public IHttpActionResult PostJson(dynamic json)
        {
            return Json<dynamic>(json);
        }
    }
}

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Linq;
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

        [Route("File")]
        [HttpGet]
        public HttpResponseMessage GetFile()
        {
            var fileName = "test.csv";
            var content = "Hello world";
            var bytes = Encoding.UTF8.GetBytes(content);
            var buffer = Encoding.UTF8.GetPreamble().Concat(bytes).ToArray();
            var fileContent = new ByteArrayContent(buffer);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = fileName
            };
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = fileContent
            };
        }
    }
}

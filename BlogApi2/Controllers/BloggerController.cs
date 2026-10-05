using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi2.Controllers
{
    [Route("blogger")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        [HttpGet]
        public string Get() 
        {
            return "Hello World"; 
        }


        [HttpGet("getAll")]
        public ResponseResult GetAll()
        {
            var message = new ResponseResult
            {
                Message = "Hello world"
            };


            return message;
        }
    }


    public class ResponseResult
    {
        public string Message { get; set; }
    }



}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi2.Controllers
{
    [Route("blogger")]//alapértelmezett elérési útvonal
    [ApiController]
    public class BloggerController : ControllerBase
    {

        public readonly string ConnectionString = "server=localhost;database=blog2;password=";

        [HttpGet("bloggers")] //attribútum
        public object GetAllBlogger() 
        {
            return "Hello World";
        }

    }


}

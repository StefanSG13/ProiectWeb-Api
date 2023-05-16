using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Service.Services.IServices;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _bookService.GetAll();

            return Ok(result);
        }


        [HttpGet("get")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _bookService.Get(id);

            return Ok(result);
        }

        [HttpGet("get-range")]
        public async Task<ActionResult> GetRange([FromQuery]List<int> ids)
        {
            var result = await _bookService.GetRange(ids);

            return Ok(result);
        }
    }
}

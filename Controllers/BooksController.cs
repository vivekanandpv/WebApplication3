using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IConfiguration _config;
        private readonly IBookService _service;

        public BooksController(ILoggerFactory loggerFactory, IConfiguration config, IBookService service)
        {
            _config = config;
            _service = service;
            _logger = loggerFactory.CreateLogger<BooksController>();
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(BookViewModel book)
        {
            await _service.Create(book);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateWithPutAsync(int id, BookViewModel book)
        {
            return Ok(await _service.Update(id, book));
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateWithPatchAsync(int id, BookViewModel book)
        {
            return Ok(await _service.Update(id, book));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _service.Delete(id);
            return Ok(new { Message = $"Delete int({id}): OK" });
        }
    }
}

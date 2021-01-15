using System.Collections.Generic;
using System.Threading.Tasks;
using API.Contracts;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Application.Homes;

namespace API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase {
        private readonly IHomeService _service;
        public HomeController (IHomeService service) {
            _service = service;
        }

        // Show All the Properties
        [HttpGet]
        public async Task<ActionResult<SearchResult>> List()
        {
            return await _service.ListAsync();
        }

        // View Properties By Property Id
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeDTO>> Details(int id)
        {
            var item = await _service.DetailsAsync(id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // Add new Property
        [HttpPost]
        public async Task<ActionResult<Home>> Create(Home home)
        {
            return await _service.CreateAsync(home);
        }

        // Modify Property
        [HttpPut("{id}")]
        public async Task<ActionResult<Home>> Edit(int id, Home home)
        {
            return await _service.EditAsync(id,home);
        }

        // Delete Property
        [HttpDelete("{id}")]
        public async Task<ActionResult<dynamic>> Delete(int id)
        {
            return await _service.DeleteAsync(id);
        }
    }
}
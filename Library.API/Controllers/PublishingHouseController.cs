using Library.Application.Repositories;
using Library.Application.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublishingHouseController : Controller
    {
        private readonly IPublishingHouseService _publishinHouseService;

        public PublishingHouseController(IPublishingHouseService publishinHouseService)
        {
            _publishinHouseService = publishinHouseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var publishingHouse = new PublishingHouse("House", "Lublin", "Poland");

            await _publishinHouseService.AddAsync(publishingHouse);

            return Ok();
        }
    }
}

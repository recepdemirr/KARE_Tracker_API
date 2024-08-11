using KARE_Tracker_API.Bussiness.Abstract;
using KARE_Tracker_API.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace KARE_Tracker_API.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IProductService _Service;

        public ProductController(IProductService service)
        {
            _Service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_Service.GetAll());
        }
        [HttpPost("Add")]
        public IActionResult Add(Products products)
        {
            return Ok(_Service.Add(products));
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int id)
        {
            _Service.Delete(id);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(Products products)
        {
            return Ok(_Service.Update(products));
        }
    }
}
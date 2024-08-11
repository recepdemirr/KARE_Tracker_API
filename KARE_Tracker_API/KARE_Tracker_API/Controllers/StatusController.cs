using KARE_Tracker_API.Bussiness.Abstract;
using KARE_Tracker_API.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace KARE_Tracker_API.Controllers
{
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _Service;

        public StatusController(IStatusService  Service)
        {
            _Service = Service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_Service.GetAll());
        }
        [HttpPost("Add")]
        public IActionResult Add(Status statuses)
        {
            return Ok(_Service.Add(statuses));
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int id)
        {
            _Service.Delete(id);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(Status statuses)
        {
            return Ok(_Service.Update(statuses));
        }
    }
}

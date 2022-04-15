using asp_net_mvc.Models.AnnouncementModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nedrysoft_TestTask.Entity;
using nedrysoft_TestTask.Models;
using nedrysoft_TestTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nedrysoft_TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnounsmentController : ControllerBase
    {
        private readonly IAnnouncementService _announsmentService;

        public AnnounsmentController(IAnnouncementService announsmentService)
        {
            _announsmentService = announsmentService;
        }
        [HttpGet("GetAnnouncements")]
        public IEnumerable<GetAnnouncementAnnouncementItem> GetAnnouncements()
        {
            var announsments = _announsmentService.GetAnnouncements();
            return announsments;
        }     
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateAnnouncementModel model)
        {
            var responseModel = new ResponceCreateAnnouncementModel();
            await _announsmentService.Create(model, responseModel);
            return Ok();
        }

        [HttpPost("Delete/{announcementId}")]
        public async Task<IActionResult> Delete(int announcementId)
        {
            await _announsmentService.Delete(announcementId);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAnnouncementModel model)
        {
            await _announsmentService.Update(model);
            return Ok();
        }


    }
}

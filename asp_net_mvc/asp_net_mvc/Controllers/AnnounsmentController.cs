using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp_net_mvc.Entity;
using asp_net_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_mvc.Service;
using asp_net_mvc.Models.AnnouncementModels;

namespace asp_net_mvc.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class AnnounsmentController : Controller
    {
        private readonly IAnnounsmentService _announsmentService;

        public AnnounsmentController(IAnnounsmentService announsmentService)
        {
            _announsmentService = announsmentService;
        }
        [HttpGet("GetAnnouncements")]
        public IEnumerable<GetAnnouncementAnnouncementItem> GetAnnouncements()
        {
        var announsments =  _announsmentService.GetAnnouncements();
            return announsments;
        }
        [Route("")]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            var model = new IndexAnnounsmentModel();
           
            return View(model);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody]CreateAnnouncementModel model)
        {
            var responseModel = new ResponceCreateAnnouncementModel();
            await _announsmentService.Create(model, responseModel);
            return Ok();
        }

        [HttpPost("Delete/{announcementId}")]
        public async Task< IActionResult> Delete(int announcementId)
        {
           await  _announsmentService.Delete(announcementId);
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

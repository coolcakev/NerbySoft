using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nedrysoft_TestTask.Entity;
using nedrysoft_TestTask.Models;
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
        private readonly ApplicationContext repository;

        public AnnounsmentController(ApplicationContext repository)
        {
            this.repository = repository;
        }
     
        [HttpGet("GetAnnounsments")]
        public IEnumerable<Announcement> GetAnnounsments()
        {           
            var announcements = repository.Announcements.ToList();            
            return announcements;
        }
        [HttpPost("Create")]
        public Announcement Create(Announcement announcement)
        {
            announcement.DateAdded = DateTime.Now;
            repository.AddAsync(announcement);
            repository.SaveChanges();

            return announcement;
        }

        [HttpPost("Delete/{announcementId}")]
        public IActionResult Delete(int announcementId)
        {
            var announcement = repository.Announcements.SingleOrDefault(announcement => announcement.Id == announcementId);
            repository.Remove(announcement);
            repository.SaveChanges();

            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Update(Announcement announcement)
        {
            repository.Announcements.Update(announcement);
            repository.SaveChanges();

            return Ok();
        }



    }
}

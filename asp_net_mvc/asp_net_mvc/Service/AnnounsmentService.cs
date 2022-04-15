using asp_net_mvc.Entity;
using asp_net_mvc.Models.AnnouncementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_mvc.Service
{
    public interface IAnnounsmentService
    {
        IEnumerable<GetAnnouncementAnnouncementItem> GetAnnouncements();
        Task Create(CreateAnnouncementModel model, ResponceCreateAnnouncementModel responceModel);
        Task Update(UpdateAnnouncementModel model);
        Task Delete(int announcementId);
    }
    public class AnnounsmentService : IAnnounsmentService
    {
        private readonly ApplicationContext _repository;

        public AnnounsmentService(ApplicationContext repository)
        {
            _repository = repository;
        }

        public async Task Create(CreateAnnouncementModel model, ResponceCreateAnnouncementModel responceModel)
        {
            if (string.IsNullOrEmpty(model.Title))
                return;

            if (string.IsNullOrEmpty(model.Title))
                return;

            var announcement = new Announcement
            {

                DateAdded = DateTime.Now,
                Description = model.Description,
                Title = model.Title
            };

            await _repository.AddAsync(announcement);
            await _repository.SaveChangesAsync();
            responceModel.Announcement = announcement;
        }

        public async Task Delete(int announcementId)
        {
            var announcement = _repository.Announcements.SingleOrDefault(announcement => announcement.Id == announcementId);
            _repository.Remove(announcement);
            await _repository.SaveChangesAsync();
        }

        public IEnumerable<GetAnnouncementAnnouncementItem> GetAnnouncements()
        {
            var announcements = _repository.Announcements.ToList();
            var getAnnouncementAnnouncementItems = new List<GetAnnouncementAnnouncementItem>();
            foreach (var announcement in announcements)
            {
                var countSimilar = GetOrderAnnouncement(announcement, announcements);
                var getAnnouncementAnnouncementItem = new GetAnnouncementAnnouncementItem()
                {

                    Id = announcement.Id,
                    Title = announcement.Title,
                    Description = announcement.Description,
                    CreationDate = announcement.DateAdded.ToString("dd MMMM yyyy"),
                    Order= countSimilar,
                };
                getAnnouncementAnnouncementItems.Add(getAnnouncementAnnouncementItem);
            }
            return getAnnouncementAnnouncementItems.OrderByDescending(x=>x.Order);
        }

        public async Task Update(UpdateAnnouncementModel model)
        {
            if (model.Id <= 0)
                return;

            var announcement = _repository.Announcements.SingleOrDefault(announcement => announcement.Id == model.Id);
            if (announcement == null)
                return;

            announcement.Title = model.Title;
            announcement.Description = model.Description;

            _repository.Update(announcement);
            await _repository.SaveChangesAsync();

        }
        private int GetOrderAnnouncement(Announcement announcement, List<Announcement> announcements)
        {
            int countMatch = 0;       
            for (int i = 0; i < announcements.Count; i++)
            {
                var isSimilarTitle = IsSimilar(announcement.Title, announcements[i].Title);
                var isSimilarDescription = IsSimilar(announcement.Description, announcements[i].Description);

                if (isSimilarTitle || isSimilarDescription)
                    countMatch++;
            }
            
            return countMatch;
        }
        private bool IsSimilar(string firstString,string secondString)
        {
            var distinctedfirstString = clearString(firstString);
            var distinctedSecondString = clearString(secondString);
            var joinedString = distinctedfirstString +" "+ distinctedSecondString;
            var unikString = clearString(joinedString);

            return joinedString != unikString;
        }
        private string clearString(string target)
        {
            var resultArray = target.Split(" ").ToList().Distinct();
            return String.Join(" ", resultArray);
        }
    }
}

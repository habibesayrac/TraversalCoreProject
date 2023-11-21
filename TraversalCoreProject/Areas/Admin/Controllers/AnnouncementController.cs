using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements =_announcementService.TGetList();
            List<AnnouncementListViewModel> model =new();

            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new();
                announcementListViewModel.ID = item.AnnouncementID;
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;

                model.Add(announcementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
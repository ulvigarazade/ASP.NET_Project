using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHomeAspNetProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            
            


            HomeVM homeVM = new HomeVM
            {
                Sliders=_context.Sliders.ToList(),
                Services = _context.Services.ToList(),
                About =_context.Abouts.FirstOrDefault(),
                NoticeBoards = _context.NoticeBoards.OrderByDescending(b=>b.Id).ToList(),
                NoticeVideo = _context.NoticeVideos.FirstOrDefault(),
                Events = _context.Events.Take(4).ToList(),
                CourseDetails = _context.CourseDetails.ToList(),
                Courses = _context.Courses.OrderByDescending(c => c.Id).Take(3).ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Blogs = _context.Blogs.OrderByDescending(p=>p.Id).Take(3).ToList(),
                BlogCategories  = _context.BlogCategories.ToList()
            };
            

            return View(homeVM);
        }

        

    }
}

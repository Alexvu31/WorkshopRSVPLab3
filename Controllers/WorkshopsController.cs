using Microsoft.AspNetCore.Mvc;
using WorkshopRSVPLab3.Data;
using WorkshopRSVPLab3.Models;


namespace WorkshopRSVPLab3.Controllers
{
    public class WorkshopsController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(Rsvp model)
        {
            if (!ModelState.IsValid)
            {
                return View("RsvpForm", model);
            }

            _context.Rsvps.Add(model);
            _context.SaveChanges();

            ViewData["Message"] =
                $"Thanks for registering, {model.FullName}!";

            return View(model);
        }

        private readonly ApplicationDbContext _context;

        public WorkshopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Registrations()
        {
            var registrations = _context.Rsvps.ToList();

            return View(registrations);
        }
    }
}

using BizLand.DAL;
using BizLand.Models;
using BizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace BizLand.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly BizLandDbContext _context;
        public TestimonialController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            return View(_context.Testimonials.ToList().Find(x => x.Id == id));
        }
    }
}

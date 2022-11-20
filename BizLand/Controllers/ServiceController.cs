using BizLand.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace BizLand.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BizLandDbContext _context;
        public ServiceController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            return View(_context.Services.ToList().Find(x => x.Id == id));
        }
    }
}

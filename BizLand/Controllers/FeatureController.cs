using BizLand.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace BizLand.Controllers
{
    public class FeatureController : Controller
    {
        private readonly BizLandDbContext _context;
        public FeatureController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            return View(_context.Features.ToList().Find(x => x.Id == id));
        }
    }
}

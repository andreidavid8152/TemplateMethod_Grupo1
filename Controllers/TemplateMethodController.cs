using TemplateMethod.Data;
using TemplateMethod.Models;
using Microsoft.AspNetCore.Mvc;

namespace TemplateMethod.Controllers
{
    public class TemplateMethodController : Controller
    {

        private readonly ApplicationDbContext _context;


        public TemplateMethodController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}

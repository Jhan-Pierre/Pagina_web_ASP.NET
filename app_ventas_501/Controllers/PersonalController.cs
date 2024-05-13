using app_ventas_501.Data;
using app_ventas_501.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_ventas_501.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonalController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Personal> ListarPersonal = _context.Personal;
            return View(ListarPersonal);
        }
    }
}

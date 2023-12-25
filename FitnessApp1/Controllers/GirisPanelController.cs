
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp1.Controllers
{
    public class GirisPanelController : Controller
    {
        private readonly Context _context;
        public GirisPanelController(Context context)
        {

            _context = context;
        }

        public async Task<IActionResult> ShowDataKullanici()
        {
            var data = await _context.Kullanicilar.ToListAsync();
            return View(data);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

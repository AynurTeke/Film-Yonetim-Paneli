using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using filmUygulamasi.Models;
using System.Threading.Tasks;

namespace filmUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly uygulamaContext _context;

        public HomeController(uygulamaContext context)
        {
            _context = context;
        }

        // GET: Home
        public async Task<IActionResult> Index()
        {
            var uContext = _context.films;
            return View(await uContext.ToListAsync());
        }

        // Get
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string kullaniciAdi, string parola)
        {
            if (kullaniciAdi == "admin" && parola == "123456")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        public async Task<IActionResult> Saloons()
        {
            var uContext = _context.salons;
            return View(await uContext.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> SaloonsFilter(string salonAdi)
        {
            var uContext = _context.filmSalons.Include(p => p.film).Include(p => p.salon).Where(x => x.salon.salonAd == salonAdi);
            return View(await uContext.ToListAsync());
        }
        public async Task<IActionResult> SearchYear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchYear(int filmYapimYil1, int filmYapimYil2)
        {
            var uContext = _context.films.Where(x => x.filmYapimYil >= filmYapimYil1 && x.filmYapimYil <= filmYapimYil2);
            return View(await uContext.ToListAsync());
        }
        public async Task<IActionResult> Search(int id)
        {
            var uContext = _context.filmSalons.Include(p => p.film).Include(p => p.salon).Where(x => x.film.filmID == id);
            return View(await uContext.ToListAsync());
        }


        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("filmID,filmAd,filmYapimYil")] film film)
        {
            _context.Add(film);
            await _context.SaveChangesAsync();
            ViewData["filmID"] = new SelectList(_context.films, "filmID", "filmAd", "filmYapimYil");
            return View(film);
        }

        // GET: 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("filmID,filmAd,filmYapimYil")] film film)
        {
            if (id != film.filmID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                        return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }
        // GET: 
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.films
                .FirstOrDefaultAsync(m => m.filmID == id);
            if (film == null)
            {
                return NotFound();
            }
            else
            {
                film = await _context.films.FindAsync(id);
                _context.films.Remove(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


        }

    }
}

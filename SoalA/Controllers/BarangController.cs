using Microsoft.AspNetCore.Mvc;
using SoalA.Context;
using SoalA.Models;
using SoalA.Service;

namespace SoalA.Controllers
{
    public class BarangController : Controller
    {
        private readonly DatabaseContext db;
        private readonly IBarangService barangService;

        public BarangController(DatabaseContext db, IBarangService barangService)
        {
            this.db = db;
            this.barangService = barangService;
        }

        [HttpGet]
        public IActionResult Index(string search)
        {
            ViewData["GetSearch"] = search;
            if (!String.IsNullOrEmpty(search))
            {
                IEnumerable<Barang> barangList = barangService.GetAllBySearch(search);
                return View(barangList);
            }
            else
            {
                IEnumerable<Barang> barangList = barangService.GetAllBySearch("");
                return View(barangList);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Barang barang)
        {
            if (barang.Nama_Barang == barang.Kode_Barang.ToString())
            {
                ModelState.AddModelError("Nama_Barang", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                barangService.SaveOrUpdate(barang);
                TempData["success"] = "Barang berhasil ditambah";
                return RedirectToAction("index");
            }

            return View(barang);
        }

        //GET
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var barangFromDb = db.MS_Barang.Find(id);

            if (barangFromDb == null)
            {
                return NotFound();
            }

            return View(barangFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Barang barang)
        {
            if (barang.Nama_Barang == barang.Kode_Barang.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                barangService.SaveOrUpdate(barang);
                TempData["success"] = "Barang berhasil diubah";
                return RedirectToAction("index");
            }

            return View(barang);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var barangFromDb = db.MS_Barang.Find(id);

            if (barangFromDb == null)
            {
                return NotFound();
            }

            return View(barangFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var obj = db.MS_Barang.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            barangService.Delete(id);
            TempData["success"] = "Barang berhasil dihapus";
            return RedirectToAction("index");

        }
    }
}

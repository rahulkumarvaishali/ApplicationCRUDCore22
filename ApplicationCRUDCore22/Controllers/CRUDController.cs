using ApplicationCRUDCore22.Data;
using ApplicationCRUDCore22.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationCRUDCore22.Controllers
{
    public class CRUDController : Controller
    {
        private ApplicationDbContext _Db;

        public CRUDController(ApplicationDbContext db)
        {
            _Db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AppDbContext> appDbContexts=_Db.appDbContexts;
            return View(appDbContexts);
        }
       
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form(AppDbContext obj)
        {
            if (ModelState.IsValid)
            {
                _Db.appDbContexts.Add(obj);
                _Db.SaveChanges();
                TempData["fmsg"]="Add data sucessfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var res = _Db.appDbContexts.Find(id);
                if(res == null)
                {
                    return NotFound();
                }
                return View(res);
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var res = _Db.appDbContexts.Find(id);
                if (res == null)
                {
                    return NotFound();
                }
                return View(res);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AppDbContext obj)
        {
            if (ModelState.IsValid)
            {
                _Db.appDbContexts.Update(obj);
                _Db.SaveChanges();
                TempData["fmsg"] = "Update data sucessfully";

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var res = _Db.appDbContexts.Find(id);
                if (res == null)
                {
                    return NotFound();
                }
                return View(res);
            }
        }
        /* [HttpPost,ActionName("Delete")]
         [ValidateAntiForgeryToken]*/
        [HttpGet]
        public IActionResult Deletedata(int? id)
        {
            var delitem=_Db.appDbContexts.Where(a=>a.id == id).First();
            _Db.appDbContexts.Remove(delitem);
            _Db.SaveChanges();
            TempData["fmsg"] = "Delete data sucessfully";


            /*var res = _Db.appDbContexts.Find();
            if (res == null)
            {
                return NotFound();
            }
            else
            {
                _Db.appDbContexts.Remove(res);
                _Db.SaveChanges();
            }*/


            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            IEnumerable<AppDbContext> appDbContexts = _Db.appDbContexts;
            return View(appDbContexts);
        }

        
    }
}

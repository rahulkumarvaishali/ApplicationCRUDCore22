using ApplicationCRUDCore22.Data;
using ApplicationCRUDCore22.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationCRUDCore22.Controllers
{
    public class DataController : Controller
    {
        private ApplicationDbContext _Db;

        public DataController(ApplicationDbContext db)
        {
            _Db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AppDbContext> AppDbContext = _Db.appDbContexts;
            return View( AppDbContext);
        }
    }
}

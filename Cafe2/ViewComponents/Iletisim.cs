using Cafe2.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Cafe2.ViewComponents
{
    public class Iletisim:ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Iletisim(ApplicationDbContext db)
        {
            _db = db;   
        }
        public IViewComponentResult Invoke()
        {
            var iletisim = _db.Iletisims.ToList();
            return View(iletisim);
        }
    }
}

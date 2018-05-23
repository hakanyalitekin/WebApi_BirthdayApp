using BirthdayApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DavetiyeFormu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                TmpVeritabani.Add(model);
                return View("Thanks", model);
            }

            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Katilanlar()
        {
            //var katilanlar = TmpVeritabani.Listem.Where(i => i.KatilmaDurumu == true);
            return PartialView(TmpVeritabani.Listem.Where(i => i.KatilmaDurumu == true));

        }
    }
}
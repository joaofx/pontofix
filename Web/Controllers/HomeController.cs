using System.Web.Mvc;

namespace Web.Controllers
{
    using System.Collections.Generic;
    using FixPonto;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(PontoForm form)
        {
			var dias = new CalcularPonto().Calcular(form.Periodos, form.Catraca);
            return View(dias);
        }
    }
}
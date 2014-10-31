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
        public ActionResult Result(PontoInput input)
        {
            var dias = CalculaDias(input);
            return View(dias);
        }

        private static List<PontoDia> CalculaDias(PontoInput input)
        {
            var catracaDias = ParseCatraca.Parse(input.Catraca);
            var periodoDias = ParsePeriodos.Parse(input.Periodos);

            var dias = new List<PontoDia>();

            for (int index = 0; index < catracaDias.Count; index++)
            {
                var catracaDia = catracaDias[index];
                var periodoDia = periodoDias[index];

                if (string.IsNullOrEmpty(periodoDia) == false)
                {
                    var dia = new PontoDia(catracaDia, periodoDia);
                    dias.Add(dia);
                }
            }

            return dias;
        }
    }
}
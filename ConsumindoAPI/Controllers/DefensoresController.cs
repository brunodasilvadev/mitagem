using ConsumindoAPI.Mitagem;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class DefensoresController : Controller
    {
        private MitagemEstatistica _mitagemDefensores;

        public DefensoresController()
        {
            _mitagemDefensores = new MitagemEstatistica();
        }

        // GET: Defensores
        public ActionResult Index()
        {
            return View(_mitagemDefensores.Mitos(2, 3));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

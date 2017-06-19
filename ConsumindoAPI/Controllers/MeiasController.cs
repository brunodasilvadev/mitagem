using ConsumindoAPI.Mitagem;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class MeiasController : Controller
    {
        private MitagemEstatistica _mitagemMeias;

        public MeiasController()
        {
            _mitagemMeias = new MitagemEstatistica();
        }
        // GET: Meias
        public ActionResult Index()
        {
            //Meias
            return View(_mitagemMeias.Mitos(4));
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
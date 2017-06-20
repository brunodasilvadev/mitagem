using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class LateralController : Controller
    {
        MapeamentoMitos _mapeamento;

        public LateralController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        // GET: Lateral
        public ActionResult Index()
        {
            return View(_mapeamento.Mitos(2));
        }
    }
}

using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class MeiasController : Controller
    {
        MapeamentoMitos _mapeamento;

        public MeiasController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        public ActionResult Index()
        {
            // 4 - : posicao_id de meias
            return View(_mapeamento.Mitos(4));
        }
    }
}
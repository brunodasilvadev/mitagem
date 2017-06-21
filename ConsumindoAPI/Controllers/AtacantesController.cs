using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class AtacantesController : Controller
    {
        MapeamentoMitos _mapeamento;

        public AtacantesController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        // GET: Lateral
        public ActionResult Index()
        {
            //5 : posicao_id de atacante
            return View(_mapeamento.Mitos(5));
        }
    }
}

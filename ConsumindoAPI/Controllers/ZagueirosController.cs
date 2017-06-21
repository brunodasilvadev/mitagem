using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class ZagueirosController : Controller
    {
        MapeamentoMitos _mapeamento;

        public ZagueirosController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        // GET: Lateral
        public ActionResult Index()
        {
            //3 : posicao_id de zagueiros
            return View(_mapeamento.Mitos(3));
        }
    }
}

using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class MelhoresController : Controller
    {
        MapeamentoMitos _mapeamento;

        public MelhoresController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        // GET: Lateral
        public ActionResult Index()
        {
            //0 : geral
            return View(_mapeamento.Todos());
        }
    }
}
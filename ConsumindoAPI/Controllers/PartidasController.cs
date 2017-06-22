using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class PartidasController : Controller
    {
        MapeamentoMitos _mapeamento;

        public PartidasController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        public ActionResult Index()
        {   
            return View(_mapeamento.Partidas());
        }
    }
}
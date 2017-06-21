using ConsumindoAPI.Mapeamentos;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class GoleirosController : Controller
    {
        private MapeamentoMitos _mapeamento;

        public GoleirosController()
        {
            _mapeamento = new MapeamentoMitos();
        }

        // GET: Goleiros
        public ActionResult Index()
        {
            //1: posicao_id de goleiro
            return View(_mapeamento.Mitos(1));
        } 
    }
}
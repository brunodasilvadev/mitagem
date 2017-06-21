using ConsumindoAPI.Mapeamentos;
using ConsumindoAPI.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        // GET: Lateral
        public ActionResult Index()
        {
            //3 : posicao_id de zagueiros
            return View(_mapeamento.Partidas());
        }
    }
}

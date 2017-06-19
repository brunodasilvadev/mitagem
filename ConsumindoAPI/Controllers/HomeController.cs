using ConsumindoAPI.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ConsultaApi _cs;

        //public HomeController()
        //{
        //    _cs = new ConsultaApi();
        //}

        public ActionResult Index()
        {   
            //var retornoAtletas = await _cs.RetornaAtletas();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
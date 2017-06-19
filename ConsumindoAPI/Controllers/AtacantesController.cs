using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsumindoAPI.Models;
using ConsumindoAPI.Mitagem;

namespace ConsumindoAPI.Controllers
{
    public class AtacantesController : Controller
    {
        private MitagemEstatistica _mitagemAtacantes;

        public AtacantesController()
        {
            _mitagemAtacantes = new MitagemEstatistica();
        }

        // GET: Atacantes
        public ActionResult Index()
        {
            return View(_mitagemAtacantes.Mitos(5));
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

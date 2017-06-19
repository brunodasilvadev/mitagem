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
    public class GoleirosController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private MitagemGoleiro _mitagemGoleiro;

        public GoleirosController()
        {
            _mitagemGoleiro = new MitagemGoleiro();
        }

        // GET: Goleiros
        public ActionResult Index()
        {
            //return View(db.GoleiroViewModels.ToList());
            return View(_mitagemGoleiro.MitosNoGol());
        }

        //// GET: Goleiros/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GoleiroViewModel goleiroViewModel = db.GoleiroViewModels.Find(id);
        //    if (goleiroViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(goleiroViewModel);
        //}

        //// GET: Goleiros/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Goleiros/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "atleta_id,nome,apelido,posicao_id,status_id,jogos_num,DD,GS")] GoleiroViewModel goleiroViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.GoleiroViewModels.Add(goleiroViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(goleiroViewModel);
        //}

        //// GET: Goleiros/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GoleiroViewModel goleiroViewModel = db.GoleiroViewModels.Find(id);
        //    if (goleiroViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(goleiroViewModel);
        //}

        //// POST: Goleiros/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "atleta_id,nome,apelido,posicao_id,status_id,jogos_num,DD,GS")] GoleiroViewModel goleiroViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(goleiroViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(goleiroViewModel);
        //}

        //// GET: Goleiros/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GoleiroViewModel goleiroViewModel = db.GoleiroViewModels.Find(id);
        //    if (goleiroViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(goleiroViewModel);
        //}

        //// POST: Goleiros/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    GoleiroViewModel goleiroViewModel = db.GoleiroViewModels.Find(id);
        //    db.GoleiroViewModels.Remove(goleiroViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQL.Entidades;
using System.Linq;
namespace MySQL.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;
        public UsuariosController(Contexto _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View( db.USUARIOS.ToList());
        }

       
        public ActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult Create(Usuario collection)
        {
            try
            {
                db.USUARIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Edit(int id)
        {
            return View(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
        }

      
        [HttpPost]
        public ActionResult Edit(int id, Usuario dadosTela)
        {
            try
            {
                db.USUARIOS.Update(dadosTela);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("index");
        }

      
    }
}

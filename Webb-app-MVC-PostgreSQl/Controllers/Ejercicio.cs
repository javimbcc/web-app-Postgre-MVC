using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webb_app_MVC_PostgreSQl.Controllers
{
    public class Ejercicio : Controller
    {
        public Webb_app_MVC_PostgreSQL_DAL.Modelos.AlumnosContext db = new Webb_app_MVC_PostgreSQL_DAL.Modelos.AlumnosContext();
        // GET: Ejercicio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alumnos()
        {
            var alumnos = db.EjemploAlumnos.ToList();
            return View(alumnos);
        }



    }
}

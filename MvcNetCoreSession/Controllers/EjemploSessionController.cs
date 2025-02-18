using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreSession.Controllers
{
    public class EjemploSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SessionSimple(string accion)
        {
            if (accion != null)
            {
                if (accion.ToLower() == "almacenar")
                {
                    //GUARDAMOS DATOS EN SESSION
                    HttpContext.Session.SetString("nombre", "Programeitor");
                    HttpContext.Session.SetString("hora", DateTime.Now.ToLongTimeString());
                    ViewData["MENSAJE"] = "Datos almacenado en Session";
                } else if (accion.ToLower() == "mostrar")
                {
                    //RECUPERAMOS LOS DATOS DE SESSION
                    ViewData["USUARIO"] = HttpContext.Session.GetString("nombre");
                    ViewData["HORA"] = HttpContext.Session.GetString("hora");
                }
            }
            return View();
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers
{
public class HomeController : Controller
 {
    public IActionResult Index()
    {
        Grupo.InicializarGrupo();
        ViewBag.Integrantes = Grupo.Integrantes;
        return View();
    }

   public IActionResult SelectIntegrante(int dni) 
   {
        ViewData["dni"]=dni;
          bool Contiene = Grupo.Integrantes.ContainsKey(dni);
          if(Contiene ){
            ViewBag.DatosPersonales = Grupo.Integrantes[dni].DatosPersonales;
        ViewBag.DNI = dni;
                       }
       return View("InfoDatosPersonales");
   }
   public IActionResult MostrarDatosFamiliares(int dni)
   {
 bool Contiene = Grupo.Integrantes.ContainsKey(dni);
          if(Contiene ){
          ViewBag.DatosFamiliares = Grupo.Integrantes[dni].DatosFamiliares;
          ViewBag.DNI = dni;
                       }
       return View("InfoDatosFamiliares");
   }
   public IActionResult MostrarDatosInteres(int dni)
   {
    bool Contiene = Grupo.Integrantes.ContainsKey(dni);
          if(Contiene ){
            ViewBag.DatosInteres = Grupo.Integrantes[dni].DatosIntereses;
        ViewBag.DNI = dni;
                       }
       return View("InfoDatosInteres");
   }

 }
}

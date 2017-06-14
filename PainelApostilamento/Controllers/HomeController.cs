using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainelApostilamento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Models.Protocolo> PROTOCOLOS = new List<Models.Protocolo>();
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "não concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "não concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "não concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));
            PROTOCOLOS.Add(new Models.Protocolo("15151/2017", "Sergio Orlando", "15/06", "Concluido"));


           

            
            return View("Index",PROTOCOLOS);
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
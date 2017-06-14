using PainelApostilamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace PainelApostilamento.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Cadastrar(Protocolo PROTOCOLO)
        {

           
          PROTOCOLO.CadastrarNovoProtocolo(PROTOCOLO);

            return View();
        }
    }
}
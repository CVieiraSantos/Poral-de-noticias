using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalNoticiasNovo.Models;

namespace PortalNoticiasNovo.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Detalhes(int id)
        {
                      
                var noticia = RepositorioNoticias.Noticias.FirstOrDefault(n => n.Id == id);
                return View(noticia);                        
        }

        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo == texto ||
            n.Conteudo.Contains(texto));
            return View(noticias);
                
        }
    }
}
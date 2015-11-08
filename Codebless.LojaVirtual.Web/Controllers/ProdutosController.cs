using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codebless.LojaVirtual.Dominio.Repositorio;

namespace Codebless.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio _repositorio;
        //
        // GET: /Produtos/
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos; //.Take(10); seleciona os primeiros produtos (tipo Top(10) do SQL)



            return View(produtos);
        }
	}
}
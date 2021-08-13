using APIComidaTeste.DA.Views;
using APIComidaTeste.Lib.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;

namespace APIComidaTeste.Controllers
{
    [ApiController]
    [Route("alimentos")]
    public class AlimentoController : Controller
    {
        private readonly IDatabase _db;
        public AlimentoController(IDatabase db)
        {
            _db = db;
        }



        [HttpGet]
        [Route("listar_alimentos")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(Alimento_SQLite))]
        public IActionResult ConsultaAlimentos()
        {
            var resultado = _db.Alimento.ListarAlimentos();
             return Ok();
        }
        //[HttpPost]
        //[Route("cadastrar_alimento")]
        //[SwaggerResponse((int)HttpStatusCode.OK, "", typeof(Alimento_SQLite))]
        //public IActionResult CadastrarAlimento([FromForm] Lib.ModelsView.AlimentoParametros alimentoParametros)
        //{
        //    var resultado = _db.Alimento.CadastroAlimento(alimentoParametros);
        //    return Ok();
        //}
    }
}

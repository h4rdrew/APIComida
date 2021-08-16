using APIComidaTeste.DA.Views;
using APIComidaTeste.Lib.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
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
            return Ok(resultado);
        }

        [HttpPost]
        [Route("cadastrar_alimento")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(Alimento_SQLite))]
        public IActionResult CadastrarAlimento([FromBody] Lib.ModelsView.AlimentoParametros alimentoParametros)
        {
            var alimentoDB = new LIB.ModelsDB.Model_Alimento()
            {
                ID = Guid.NewGuid(),
                Nome = alimentoParametros.Nome,
                TipoAlimento = alimentoParametros.TipoAlimento,
            };

            var resultado = _db.Alimento.CadastroAlimento(alimentoDB);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("buscar_alimento")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(Alimento_SQLite))]
        public IActionResult BuscarAlimento(string nomeAlimento)
        {
            var resultado = _db.Alimento.BuscarAlimento(nomeAlimento);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("random_alimentos")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(Alimento_SQLite))]
        public IActionResult Teste()
        {
            var resultado = _db.Alimento.RandomAliemento();
            return Ok(resultado);
        }
    }
}

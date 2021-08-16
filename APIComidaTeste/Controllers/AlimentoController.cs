using APIComidaTeste.DA.Views;
using APIComidaTeste.Lib.Interfaces;
using APIComidaTeste.Lib.ModelsView;
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
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult ConsultaAlimentos()
        {
            var resultado = _db.Alimento.ListarAlimentos();
            return Ok(resultado);
        }

        [HttpPost]
        [Route("cadastrar_alimento")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult CadastrarAlimento([FromBody] AlimentoParametros alimentoParametros)
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
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult BuscarAlimento(string nomeAlimento)
        {
            var resultado = _db.Alimento.BuscarAlimento(nomeAlimento);
            return Ok(resultado);
        }
        [HttpGet]
        [Route("buscar_alimento_guid")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult BuscarAlimentoGuid(Guid guid)
        {
            var resultado = _db.Alimento.BuscarAlimento(guid);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("random_alimentos")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult RandomAlimento()
        {
            var resultado = _db.Alimento.RandomAliemento();
            return Ok(resultado);
        }

        [HttpPost]
        [Route("atualizar_alimento")]
        [SwaggerResponse((int)HttpStatusCode.OK, "", typeof(AlimentoParametros))]
        public IActionResult Atualizar_Alimento([FromBody] AlimentoParametros AlimentoParametros)
        {
            var alimentoDB = new LIB.ModelsDB.Model_Alimento
            {
                ID = (Guid)AlimentoParametros.ID,
                Nome = AlimentoParametros.Nome,
                TipoAlimento = AlimentoParametros.TipoAlimento,
            };

            var resultado = _db.Alimento.AtualizarAlimento(alimentoDB); 

            return Ok(resultado);
        }
    }
}

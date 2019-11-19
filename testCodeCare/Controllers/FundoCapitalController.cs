using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using testCodeCare.Models;

namespace testCodeCare.Controllers
{

    [Route("v1/fundoscapital")]
    public class FundoCapitalController : Controller
    {
        [HttpGet]
        [Route("ListarFundos")]
        public IActionResult ListarFundos()
        {
            return Ok(
                new List<FundoCapital>{
                    new FundoCapital{
                        Nome = "Viagem de férias",
                        ValorAtual = 200,
                        ValorNecessario = 5000,
                        DataResgate = new DateTime(2019,12,01)
                    },
                    new FundoCapital{
                        Nome = "Reserva de emergência",
                        ValorAtual = 400,
                        ValorNecessario = 10000,
                    }
                }
            );
        }

        [HttpPost]
        [Route("AdicionarFundo")]
        public IActionResult AdicionarFundo([FromBody]FundoCapital fundo)
        {
            return Ok();
        }

        [HttpPut]
        [Route("AlterarFundo/{id}")]
        public IActionResult AlterarFundo(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("ObterFundo/{id}")]
        public IActionResult ObterFundo(Guid id)
        {
            return Ok(
                 new FundoCapital{
                        Nome = "Viagem de férias",
                        ValorAtual = 200,
                        ValorNecessario = 5000,
                        DataResgate = new DateTime(2019,12,01)
                    }
            );
        }

        [HttpDelete("v1/fundoscapital/{id}")]
        [Route("RemoverFundo/{id}")]
        public IActionResult RemoverFundo(Guid id)
        {
            return Ok();
        }
    }
}
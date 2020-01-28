using LoLHelpsAPI.Models.Request;
using LoLHelpsAPI.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoLHelpsAPI.Controllers
{
    [ApiController]
    [Route("api/campeoes")]
    public class CampeoesController : ControllerBase
    {
        private readonly ICampeoesRepository _repository;

        public CampeoesController(ICampeoesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public Task<IList<CampeoesResponse>> ListarCampeoes()
        {
            var response = _repository.ListarCampeoes();
            return response;
        }
    }
}

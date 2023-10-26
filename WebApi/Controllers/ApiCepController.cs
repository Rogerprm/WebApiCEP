
using Microsoft.AspNetCore.Mvc;
using WebApi.Interface;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCepController : ControllerBase
    {
        private readonly IApiCepService _apiCep;
        public ApiCepController(IApiCepService apiCep)
        {
            _apiCep = apiCep;

        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetByCep([FromRoute]string cep) 
        {
            var apiCepModel = await _apiCep.GetByCep(cep);

            if (apiCepModel != null)
            {
                return Ok(apiCepModel);
            }
            else
            {
                return NotFound();
            }

        } 
    }
}

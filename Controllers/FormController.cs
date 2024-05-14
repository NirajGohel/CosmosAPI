using CosmosAPI.Models;
using CosmosAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly FormRepository _formRepository;

        public FormController(FormRepository studentRepository)
        {
            _formRepository = studentRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Form>> Post([FromBody] Form form)
        {
            var createdForm = await _formRepository.CreateFormAsync(form);            
            return createdForm;
        }
    }
}

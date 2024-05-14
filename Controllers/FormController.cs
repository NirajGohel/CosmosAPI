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

        public FormController(FormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Form>> Post([FromBody] Form form)
        {
            var createdForm = await _formRepository.CreateFormAsync(form);            
            return createdForm;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Form>> Put(string id, [FromBody] Form form)
        {
            var updatedArticle = await _formRepository.UpdateFormAsync(id, form);
            
            if (updatedArticle == null)
                return NotFound();

            return updatedArticle;
        }
    }
}

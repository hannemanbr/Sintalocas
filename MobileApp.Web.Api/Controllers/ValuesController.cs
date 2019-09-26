using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MobileApp.Application.Interfaces;
using MobileApp.Infra.ObjectsDataTransfers.Classes;

namespace MobileApp.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<NoticiaDTO> Get([FromServices] INoticiaService service)
        {
            return service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id, [FromServices] INoticiaService service)
        {
            return service.GetById(id)?.Titulo;
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Net5Template.Application.Interfaces;
using Net5Template.Domain.Models;
using Net5Template.API.Filters;

namespace Net5Template.API.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class GroupTaskController : ControllerBase
    {
        private readonly IService _service;

        public GroupTaskController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult Test()
        {
            return Ok(new OperationModel() { Result = 1, Message = "Test success!" });
        }
        [HttpPost]
        [ValidateModel]
        public ActionResult WriteGroupTask([FromBody] GroupTaskWriteModel model)
        {
            var res = _service.WriteGroupTask(model);

            return Ok(res);
        }
    }
}

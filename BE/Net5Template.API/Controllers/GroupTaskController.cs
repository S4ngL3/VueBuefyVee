using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Net5Template.Application.Interfaces;

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
    }
}

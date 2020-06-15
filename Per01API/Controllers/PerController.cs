using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Per01API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerController : ControllerBase
    {
        private IPerService _perService;
        private IPerListService _perListService;

        public PerController(IPerService perService, IPerListService perListService)
        {
            _perService = perService;
            _perListService = perListService;
        }


        [HttpPost("add")]
        public IActionResult Add(Per per)
        {
            var result = _perService.Add(per);
            if (result.Success)
            {
                return Ok(result.Message);

            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Per per)
        {
            var result = _perService.Update(per);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Per per)
        {
            var result = _perService.Delete(per);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _perListService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}

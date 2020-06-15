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
        public PerController(IPerService perService)
        {
            _perService = perService;

        }


        [HttpPost("add")]
        public IActionResult Add(PerList per)
        {
            var result = _perService.Add(per);
            if (result.Success)
            {
                return Ok(result.Message);

            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(PerList per)
        {
            var result = _perService.Update(per);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PerList per)
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
            var result = _perService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}

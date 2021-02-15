using EBook.Business.Abstract;
using EBook.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassessController : ControllerBase
    {
        IClassesService _classesService;

        public ClassessController(IClassesService classesService)
        {
            _classesService = classesService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _classesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _classesService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("Add")]
        public IActionResult Add(Classes classes)
        {
            var result = _classesService.Add(classes);
            if (result.Success)
            {
                return Ok(result);
            }
            return
            BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Classes classes)
        {
            var result = _classesService.Delete(classes);
            if (result.Success)
            {
                return Ok(result);
            }
            return
            BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Classes classes)
        {
            var result = _classesService.Update(classes);
            if (result.Success)
            {
                return Ok(result);
            }
            return
            BadRequest(result);
        }
    }
}

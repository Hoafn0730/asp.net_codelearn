﻿using BLL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryBusiness _cBusiness;
        public CategoryController(ICategoryBusiness cBusiness)
        {
            _cBusiness = cBusiness;
        }

        [Route("get-all")]
        [HttpGet]
        public IActionResult GetDataById()
        {
            var dt = _cBusiness.GetAll().Select(x => new { x.categoryId,  x.name, x.description });
            return Ok(dt);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCom.CustomGIS.Interface.Attribute;
using DevCom.CustomGIS.Interface.Attribute.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevCom.OpenGIS.App.Controller
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiVersion("1")]
    public class AttributeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IAttributeService _attributeService;

        public AttributeController(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateAttributeDto dto)
        {
            return await _attributeService.CreateAsync(dto);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(UpdateAttributeDto dto)
        {
            return await _attributeService.UpdateAsync(dto);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> Remove(Guid id)
        {
            return await _attributeService.RemoveAsync(id);
        }

        [HttpGet]
        public async Task<ActionResult<AttributeDto[]>> GetAllAttributes()
        {
            return await _attributeService.GetAllAttributesAsync();
        }


        [HttpGet]
        public async Task<ActionResult<AttributeTypeDto[]>> GetAllAttributeTypes()
        {
            return await _attributeService.GetAllAttributeTypesAsync();
        }
    }
}

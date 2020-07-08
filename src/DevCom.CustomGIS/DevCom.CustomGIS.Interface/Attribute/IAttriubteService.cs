using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevCom.CustomGIS.Interface.Attribute.Dto;

namespace DevCom.CustomGIS.Interface.Attribute
{
    interface IAttriubteService
    {
        Task<Guid> CreateAsync(CreateAttributeDto attribute);
        Task<bool> UpdateAsync(UpdateAttributeDto attribute);
        Task<bool> RemoveAsync(Guid id);
        Task<AttributeDto[]> GetAllAttributesAsync();
        Task<AttributeTypeDto[]> GetAllAttributeTypesAsync();
    }
}

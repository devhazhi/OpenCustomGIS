using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevCom.CustomGIS.Interface.Attribute;
using DevCom.CustomGIS.Interface.Attribute.Dto;

namespace DevComCustomGIS.Service.Attribute
{
    public class AttributeService : IAttributeService
    {
        public AttributeService(IAttributeNotifyChangedService notifyService)
        {
            throw new NotImplementedException();
        }
        public Task<Guid> CreateAsync(CreateAttributeDto attribute)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UpdateAttributeDto attribute)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AttributeDto[]> GetAllAttributesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AttributeTypeDto[]> GetAllAttributeTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevCom.CustomGIS.Interface.Attribute;
using DevCom.CustomGIS.Interface.Attribute.Dto;

namespace DevCom.CustomGIS.RabbitMQ.Attribute
{
    class AttributeNotifyChanged : IAttributeNotifyChangedService
    {
        public Task CreatedAsync(ChangedAttributeDto attribute)
        {
            throw new NotImplementedException();
        }

        public Task RemovedAsync(Guid attributeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatedAsync(ChangedAttributeDto attribute)
        {
            throw new NotImplementedException();
        }
    }
}

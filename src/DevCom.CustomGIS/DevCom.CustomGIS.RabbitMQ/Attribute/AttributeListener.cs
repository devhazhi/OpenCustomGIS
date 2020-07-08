using DevCom.CustomGIS.Interface.Attribute;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevCom.CustomGIS.RabbitMQ.Attribute
{
    class AttributeListener
    {
        private readonly IAttributeService _attributeService;

        public AttributeListener(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

    }
}

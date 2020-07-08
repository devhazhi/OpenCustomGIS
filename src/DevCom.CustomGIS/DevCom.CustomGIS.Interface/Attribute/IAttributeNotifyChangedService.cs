using System;
using System.Threading.Tasks;
using DevCom.CustomGIS.Interface.Attribute.Dto;

namespace DevCom.CustomGIS.Interface.Attribute
{
    public interface IAttributeNotifyChangedService
    {
        Task CreatedAsync(ChangedAttributeDto attribute);
        Task UpdatedAsync(ChangedAttributeDto attribute);
        Task RemovedAsync(Guid attributeId);
    }
}

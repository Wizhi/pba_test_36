using System.Collections.Generic;

namespace AreaCalculation.Domain
{
    public interface IPropertyRepository
    {
        ICollection<Property> GetAll();
    }
}
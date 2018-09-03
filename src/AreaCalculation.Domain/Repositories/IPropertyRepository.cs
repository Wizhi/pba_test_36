using System.Collections.Generic;

namespace AreaCalculation.Domain.Repositories
{
    public interface IPropertyRepository
    {
        ICollection<IProperty> GetAll();
    }
}
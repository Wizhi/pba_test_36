using System.Linq;
using AreaCalculation.Domain;
using AreaCalculation.Domain.Repositories;

namespace AreaCalculation
{
    public class PropertyCalculator : IPropertyCalculator
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyCalculator(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public double CalculateSquareMeters()
        {
            var properties = _propertyRepository.GetAll();

            return properties.Sum(x => x.SquareMeters);
        }
    }
}
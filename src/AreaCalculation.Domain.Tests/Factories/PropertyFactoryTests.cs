using AreaCalculation.Domain.Factories;
using Xunit;

namespace AreaCalculation.Domain.Tests.Factories
{
    public class PropertyFactoryTests
    {
        [Fact]
        public void Create_Valid_ReturnsInitialized()
        {
            var propertyFactory = new PropertyFactory();
            var propertyNumber = 1;
            var propertySquareMeters = 30d;
            var propertyRooms = 1d;

            var property = propertyFactory.Create(propertyNumber, propertySquareMeters, propertyRooms);

            Assert.Equal(property.Number, propertyNumber);
            Assert.Equal(property.SquareMeters, propertySquareMeters);
            Assert.Equal(property.Rooms, propertyRooms);
        }
    }
}
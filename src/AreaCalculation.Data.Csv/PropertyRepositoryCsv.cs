using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using AreaCalculation.Domain;

namespace AreaCalculation.Data.Csv
{
    public class PropertyRepositoryCsv : IPropertyRepository
    {
        private readonly string _csvPath;
        private readonly IFileSystem _fileSystem;
        private readonly ICsvPropertyMapper _csvPropertyMapper;

        public PropertyRepositoryCsv(string csvPath, IFileSystem fileSystem, ICsvPropertyMapper csvPropertyMapper)
        {
            _csvPath = csvPath;
            _fileSystem = fileSystem;
            _csvPropertyMapper = csvPropertyMapper;
        }

        public ICollection<Property> GetAll()
        {
            // Assume Path exists
            return _fileSystem
                .File
                .ReadAllLines(_csvPath)
                .Select(_csvPropertyMapper.Map)
                .ToList();
        }
    }
}
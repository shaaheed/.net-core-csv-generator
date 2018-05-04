using System.Collections.Generic;

namespace CsvGeneratorExample
{
    public interface ICsvGenerator
    {
        byte[] Generate(IEnumerable<object> collection);
    }
}

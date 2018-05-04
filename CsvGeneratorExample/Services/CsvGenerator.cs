using CsvHelper;
using System.Collections.Generic;
using System.IO;

namespace CsvGeneratorExample
{
    public class CsvGenerator : ICsvGenerator
    {

        public byte[] Generate(IEnumerable<object> collection)
        {
            using (var stream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    var csvWriter = new CsvWriter(streamWriter);
                    csvWriter.WriteRecords(collection);
                    streamWriter.Flush();
                }
                return stream.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace CsvGeneratorExample.Models
{
    public class CsvModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public static IEnumerable<CsvModel> GetCsvModels()
        {
            return new List<CsvModel>()
            {
                new CsvModel { Id = 1, Code = "one", Name = "One", CreatedAt = DateTime.Now },
                new CsvModel { Id = 2, Code = "two", Name = "Two", CreatedAt = DateTime.Now },
                new CsvModel { Id = 3, Code = "three", Name = "Three", CreatedAt = DateTime.Now },
                new CsvModel { Id = 4, Code = "four", Name = "Four", CreatedAt = DateTime.Now },
                new CsvModel { Id = 5, Code = "five", Name = "Five", CreatedAt = DateTime.Now },
            };
        }

    }
}

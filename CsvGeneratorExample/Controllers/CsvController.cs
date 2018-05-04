using CsvGeneratorExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace CsvGeneratorExample.Controllers
{
    [Route("api")]
    public class CsvController : Controller
    {

        private readonly ICsvGenerator _csvGenerator;

        public CsvController(ICsvGenerator csvGenerator)
        {
            _csvGenerator = csvGenerator;
        }

        // POST api/csv
        [HttpPost("csv")]
        public IActionResult Post()
        {
            string csvContentType = "text/csv";
            HttpContext.Response.ContentType = csvContentType;
            var models = CsvModel.GetCsvModels();
            var csv = _csvGenerator.Generate(models);
            return new FileContentResult(csv, csvContentType)
            {
                FileDownloadName = "test.csv",
            };
        }
    }
}

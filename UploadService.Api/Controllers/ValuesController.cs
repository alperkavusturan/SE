using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UploadService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");
            var extension = file.FileName.Split('.');
            var fileName = Helper.Helper.GetHashString(string.Concat(file.FileName + DateTime.UtcNow));

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "Uploaded",
                        string.Concat(fileName,".", extension[extension.Length-1]));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok();
        }



    }
}

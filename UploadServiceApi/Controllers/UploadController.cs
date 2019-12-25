using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadServiceApi.Entity;

namespace UploadServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public async Task<UploadFileResponse> Post([FromForm]IFormFile file)
        {
            var response = new UploadFileResponse();

            if (file == null || file.Length == 0)
            {
                response.Message = string.Concat("File not selected!");
                response.isSuccess = false;

                return response;
            }




            var extension = file.FileName.Split('.');
            var fileName = Helper.Helper.GetHashString(string.Concat(file.FileName + DateTime.UtcNow));

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        string.Concat(fileName, ".", extension[extension.Length - 1]));

            response.FileName = string.Concat(fileName, ".", extension[extension.Length - 1]);

            try
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                response.Message = string.Concat("File successfully uploaded.");
                response.isSuccess = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.ToString();
                response.isSuccess = false;
            }


            return response;
        }


    }
}
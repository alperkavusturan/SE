using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadServiceApi.Entity
{
    public class UploadFileResponse
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }
    }
}

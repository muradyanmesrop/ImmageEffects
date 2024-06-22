using ImmageEffects.Core.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmageEffects.Core.Operations
{
    public interface IAddFileOperation
    {
        public ImageModel AddFile(IFormFile file, string folderName);
    }
}

using ImmageEffects.Core.Model;
using ImmageEffects.Core.Operations;
using Microsoft.AspNetCore.Mvc;

namespace ImmageEffects.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IAddFileOperation _addFileOperation;
        private readonly IChangeImage _changeImage;

        public ImageController(IAddFileOperation addFileOperation, IChangeImage changeImage)
        {
            _addFileOperation = addFileOperation;
            _changeImage = changeImage;
        }
        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            var addedFile = _addFileOperation.AddFile(file, "UploadFile");
            return Created("", addedFile);
        }

        [HttpPut("resize")]
        public IActionResult ResizeImage([FromBody] ImageModel imageModel)
        {
            var resizedImage = _changeImage.ResizeImage(imageModel);
            return Ok(resizedImage);
        }
        [HttpPut("changeRadius")]
        public IActionResult ChangeRadius([FromBody] ImageModel imageModel)
        {
            var ChangedImage = _changeImage.ResizeImage(imageModel);
            return Ok(ChangedImage);
        }
        [HttpPut("addEffects")]
        public IActionResult AddEffect([FromBody] EffectModel effectModel)
        {
            var ChangedImage = _changeImage.AddEffects(effectModel);
            return Ok(ChangedImage);
        }
    }
}

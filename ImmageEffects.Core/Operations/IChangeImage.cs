using ImmageEffects.Core.Model;
using Microsoft.AspNetCore.Http;

namespace ImmageEffects.Core.Operations
{
    public interface IChangeImage
    {
        public ImageModel ResizeImage(ImageModel imageModel);
        public ImageModel ChangeRadius(ImageModel imageModel);
        public ImageModel AddEffects(EffectModel effectModel);
    }
}

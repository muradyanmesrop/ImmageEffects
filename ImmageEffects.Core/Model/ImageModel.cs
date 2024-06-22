using ImmageEffects.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmageEffects.Core.Model
{
    public class ImageModel : IImageAbstraction
    {
        public int? SizePixel { get; set; }
        public decimal? Radius { get; set; }
        public int? FileID { get; set; }
        public string? FileName { get; set; }
        public string? FileFormat { get; set; }
        public IEnumerable<EffectModel>? EffectModels { get; set; }
    }
}

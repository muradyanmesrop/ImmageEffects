using ImmageEffects.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmageEffects.Core.Abstraction
{
    public interface IImageAbstraction : IFileAbstraction
    {
        public int? SizePixel { get; set; }
        public decimal? Radius { get; set; }
        public IEnumerable<EffectModel> EffectModels { get; set; }
    }
}

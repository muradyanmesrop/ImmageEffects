using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmageEffects.Core.Abstraction
{
    public interface IFileAbstraction
    {
        public int? FileID { get; set; }
        public string FileName { get; set; }
        public string FileFormat { get; set; }
    }
}

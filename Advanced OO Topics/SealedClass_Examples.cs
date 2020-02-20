using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    public sealed class SealedClass_Example
    {
       
        public SealedClass_Example(string _penType)
        {
            Pentype = _penType;
        }

        public string Pentype { get; set; }

        public string return_PenType()
        {
            return Pentype;
        }
    }
}

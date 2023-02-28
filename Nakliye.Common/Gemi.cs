using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.Common
{
  public  class Gemi
    {
        public string GemiAdi { get; set; }
        public double Tonaj { get; set; }
        public override string ToString()
        {
            return GemiAdi.ToUpper();
        }
    }
}

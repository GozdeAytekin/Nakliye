using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.Common
{
   public class MusteriLojistik
    {
        public Musteri Musteri { get; set; }
        public double TasitascagiYukMiktari { get; set; }
        public DateTime IslemTarihi { get; set; }
        public Rota LojistikRotasi { get; set; }
    }
}

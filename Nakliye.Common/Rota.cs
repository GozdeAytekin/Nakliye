using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.Common
{
    public class Rota
    {
        public Gemi RotaninGemisi { get; set; }
        public string KalkisLimani { get; set; }
        public string VaarisLimani { get; set; }
        public string UgranacakLiman { get; set; }
        public DateTime KalkisTarihi { get; set; }
        public DateTime VarisTarihi { get; set; }
        public override string ToString()
        {
            return string.Format(" {0} isimli gemi ile kalkış : {1} ugranacak: {2} varış:{3} Tarihler {4} -  {5}",RotaninGemisi.GemiAdi,KalkisLimani,UgranacakLiman,VaarisLimani,KalkisTarihi,VarisTarihi);
        }
    }
}

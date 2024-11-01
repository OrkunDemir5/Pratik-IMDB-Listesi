using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_IMDB_Listesi
{
    public class Film
    {
        // Film sınıfının özellikleri
        public double ImdbPuani { get; set; }
        public string Isim { get; set; }

        public Film(double imdbPuani, string isim)
        {
            ImdbPuani = imdbPuani;
            Isim = isim;
        }
    }


}

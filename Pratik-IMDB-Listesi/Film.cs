using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_IMDB_Listesi
{
    internal class Film
    {
        // Film adını tutan özellik
        public string Isim { get; set; }

        // IMDB puanını tutan özellik
        public double ImdbPuani { get; set; }

        // Film sınıfının yapıcı metodu
        public Film(string isim, double imdbPuani)
        {
            Isim = isim;
            ImdbPuani = imdbPuani;
        }
    }
}

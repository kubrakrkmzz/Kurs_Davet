using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_Davet.Models
{
    public class Repository
    {
        //Bilgiler classını kullanarak list oluşturuyoruz
        public static List<Bilgiler> bilgiler = new List<Bilgiler>();
        //IEnumerable , liste içerisinde dönmeyi sağlar
        public static IEnumerable<Bilgiler> Bilgiler => bilgiler;

        public static void CevapEkle(Bilgiler bilgi)
        {
            bilgiler.Add(bilgi);
        }




    }
}

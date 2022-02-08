using DAL;
using Kütüphane_Otomasyon.DataAccessLayer;
using Kütüphane_Otomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   // Entity katmanını kullandık


namespace BL
{
    public class GorevliBL
    {
        //Class'i public olarak tanımlamamızın sebebi diğer classlardan erişim sağlayabilmek için

        //Girilen tc ve sifreye ait görevli veri tabanında kayıtlı mı diye DAL katmanı kullanılarak kontrol edildi
        public static bool gorevliKontrol_BL(Görevli gorevli)
        {
            if (gorevli.gorevTc != "" && gorevli.gorevSifre != "")
                return GorevliDAL.gorevliKontrol(gorevli);

            else
                return false;
        }
    }
}

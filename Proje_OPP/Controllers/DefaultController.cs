using Microsoft.AspNetCore.Mvc;
using Proje_OPP.Ornekler;

namespace Proje_OPP.Controllers
{
    public class DefaultController : Controller
    {
        //void İslemler()
        //{
        //    Class c = new Class();
        //    c.topla();
        //    c.Carp();
        //}

        public void Messages()
        {
            ViewBag.m1 = "Merhaba bu bır core projesidir.";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selam dostum";
        }
        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int Cevre()
        {
            int kısakenar = 10;
            int uzunkenar = 40;
            int c = 2 * (kısakenar + uzunkenar);
            return c;
        }
        int faktoriyel()
        {
            int sayi = 6;
            int f = 1;
            for (int i = 1; i <= sayi; i++)
            {
                f = f * i;
            }
            return f;
        }
        string cumle()
        {
            string c = "Küçük Hanımlar Küçük Beyler Sizler Hepiniz Geleceğin Birer Gülü Parlayan,Işık Saçan Yıldızı Olacaksınız";
            return c;

        }
        void mesajListesi(string p)
        {
            ViewBag.v = p;

        }
        void Kullanıcı(string username)
        {

            ViewBag.v = username;

        }


        public IActionResult Index()
        {
            Messages();
            mesajListesi("kurs devam ediyor");
            Kullanıcı("vasfiolmez");
            return View();
        }

        public IActionResult Products()
        {
            Messages();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            ViewBag.f = faktoriyel();
            Kullanıcı("vasfiolmez07");
            return View();
        }
        public IActionResult Customers()
        {
            ViewBag.s = cumle();
            Kullanıcı("vasfiolmez008");
            return View();
        }
        public IActionResult deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.SehirAd = "kiev";
            sehirler.SehirID = 1;
            sehirler.Nufus = 10000000;
            sehirler.Ulke = "Ukrayna";
            ViewBag.v1 = sehirler.SehirID;
            ViewBag.v2 = sehirler.SehirAd;
            ViewBag.v3 = sehirler.Ulke;
            ViewBag.v4 = sehirler.Nufus;

            sehirler.SehirAd = "Üsküp";
            sehirler.SehirID = 2;
            sehirler.Nufus = 500000;
            sehirler.Ulke = "Makedonya";
            ViewBag.z1 = sehirler.SehirID;
            ViewBag.z2 = sehirler.SehirAd;
            ViewBag.z3 = sehirler.Ulke;
            ViewBag.z4 = sehirler.Nufus;

            return View();
        }

    }
}

using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilanlar() //GetKatilanlar  GET ve POST eklersek özlel bir durum oluyor üsttekine gerek kalmıyor.
        {
            return TmpVeritabani.Listem.Where(i => i.KatilmaDurumu == true);
        }
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilmayanlar() //GetKatilanlar  GET ve POST eklersek özlel bir durum oluyor üsttekine gerek kalmıyor.
        {
            return TmpVeritabani.Listem.Where(i => i.KatilmaDurumu == false);
        }

        [HttpPost]
        public void Ekle(DavetiyeModel model) //PostEkle GET ve POST eklersek özlel bir durum oluyor üsttekine gerek kalmıyor.
        {
            if (ModelState.IsValid)
            {
                //Thread.Sleep(3000); loader'ı beklektemek istediğimiz saniye. (çok hılzı olduğunda gösterim maksadı var sadece.)
                TmpVeritabani.Add(model);
            }
        }
    }
}

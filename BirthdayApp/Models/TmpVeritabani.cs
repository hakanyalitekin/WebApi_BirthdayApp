using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class TmpVeritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;

        static TmpVeritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("1Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("2Ali", new DavetiyeModel
            {
                Ad = "Ali",
                Eposta = "ali@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("3Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Eposta = "Eposta",
                KatilmaDurumu = false
            });
        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key,model);
            }
        }
        public static IEnumerable<DavetiyeModel> Listem
        {
            get { return _liste.Values; }
        }
    }
}
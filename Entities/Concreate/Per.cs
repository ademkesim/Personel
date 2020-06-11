﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entities.Concreate
{
    public class Per:IEntity
    {
        public string sicil { get; set; }
        public string  sirket { get; set; }//Primary key
        public int pay_no { get; set; }//Primary key
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int tc { get; set; }
        public string cins { get; set; }
        public DateTime gir_ta1 { get; set; }
        public DateTime cikis_tar{ get; set; }
        public DateTime ssk_tar { get; set; }
        public decimal ucret { get; set; }
        public DateTime gorev_tarihi { get; set; }
        public int cocuk_sayi1 { get; set; }
        public string sehit_yak { get; set; }
        public char parttime_personel { get; set; }
        public string web_esas_kayit { get; set; }
        public DateTime kayit_ekleme_tarihi { get; set; }
        public string pozisyon { get; set; }
        public string eimza_onay { get; set; }

    }
}

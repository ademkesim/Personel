using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Entities.Concreate
{
    public class PerList : IEntity
    {
        [Key]
        public string sicil { get; set; }
        public string sirket { get; set; }//Primary key
        public string pay_no { get; set; }
        public string yis_akt { get; set; }
        public string ust_amir { get; set; }
        public string adi { get; set; }
        public string ikinci_ad { get; set; }
        public string soyadi { get; set; }
        public string e_mail1 { get; set; }
        public string amirmail { get; set; }
        public string bolumadi { get; set; }
        public string deparadi { get; set; }
        public string gorevadi { get; set; }
        public string statusadi { get; set; }
        public string costadi { get; set; }
    }
}

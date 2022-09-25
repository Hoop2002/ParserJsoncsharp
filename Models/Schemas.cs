using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJsonParser.Models
{



    public class Rootobject
    {
        [Newtonsoft.Json.JsonProperty("Clients")]
        public Client[] Clients { get; set; }
    }

    public class Client
    {
        public string Ссылка { get; set; }
        public string Наименование { get; set; }
        public decimal Факт { get; set; }
        public decimal Предъявлено { get; set; }
        public decimal КоличествоЧасов { get; set; }
        public Договорыконтрагента[] ДоговорыКонтрагента { get; set; }
    }

    public class Договорыконтрагента
    {
        public string Ссылка { get; set; }
        public string Наименование { get; set; }
        public decimal Факт { get; set; }
        public decimal Предъявлено { get; set; }
        public decimal КоличествоЧасов { get; set; }
        public Участки[] Участки { get; set; }
    }

    public class Участки
    {
        public string Ссылка { get; set; }
        public string Наименование { get; set; }
        public decimal Факт { get; set; }
        public decimal Предъявлено { get; set; }
        public decimal КоличествоЧасов { get; set; }
    }


}

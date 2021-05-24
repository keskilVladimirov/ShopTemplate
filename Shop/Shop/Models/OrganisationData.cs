using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models
{
    public class OrganisationData
    {
        public bool existCardPay { get; set; }
        public string CardPayInfo { get; set; }
        public bool existCashPay { get; set; }
        public string CashPayInfo { get; set; }
        public bool existCardOnlinePay { get; set; }
        public string CardOnlinePayInfo { get; set; }
        public string Adress { get; set; }
        public string AdressLegal { get; set; }
        public string EMail { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string OGRNIP { get; set; }
    }
}

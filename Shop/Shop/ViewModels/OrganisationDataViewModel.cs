using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Shop.ViewModels
{
    class OrganisationDataViewModel : BindableObject
    {
        private ObservableCollection<OrganisationData> organisationDatas;
        public ObservableCollection<OrganisationData> OrganisationDatas
        {
            get => organisationDatas;
            set
            {
                if (value == organisationDatas) return;
                organisationDatas = value;
                OnPropertyChanged();
            }
        }
        public OrganisationDataViewModel()
        {
            OrganisationDatas = new ObservableCollection<OrganisationData>()
            {
                new OrganisationData()
                {
                    existCardPay = true,
                    existCashPay = true,
                    existCardOnlinePay = false,
                    CardPayInfo = "Для выбора оплаты товара с помощью банковской карты на странице оплаты выберите оплату картой. Оплата происходит через ПАО СБЕРБАНК с использованием банковских карт следующих платёжных систем:",
                    CashPayInfo = "Если товар доставляется курьером, то оплата осуществляется наличными курьеру в руки. При получении товара обязательно проверьте комплектацию товара, наличие гарантийного талона и чека.",
                    CardOnlinePayInfo = "",
                    Adress = "Фактический адрес",
                    EMail = "Электронная почта",
                    AdressLegal = "Юридический адрес",
                    Number = "Телефоны",
                    Name = "Имя организации",
                    INN = "ИНН",
                    OGRNIP = "ОГРНИП",
                },
            };
        }
    }
}

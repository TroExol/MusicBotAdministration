using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class Payments
    {
        // Список оплат
        private List<Payment> _paymentsList = new List<Payment>();

        public List<Payment> PaymentsList
        {
            get => _paymentsList;
            set
            {
                _paymentsList = value;
                // Выполнить делегат при изменении списка оплат
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка оплат
        public event EventHandler OnSet;

        // Делегат при добавлении оплаты в список оплат
        public event EventHandler OnAdd;

        public Payments(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление оплаты в список оплат
        public void Add(Payment payment)
        {
            PaymentsList.Add(payment);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных об оплатах
        public static List<Payment> GetData()
        {
            var paymentsFromDb = DbConnector.Read("ОплатаПодписки",
                    "Не удалось получить данные об оплатах подписок",
                    "ОплатаПодписки.ID, ДатаОплаты, ID_Пользователь, Пользователь.ФамилияИмя, Пользователь.СсылкаНаVK, ID_Подписка",
                    "LEFT JOIN Пользователь ON ОплатаПодписки.ID_Пользователь = Пользователь.ID")
                    // " LEFT JOIN Подписка ON ОплатаПодписки.ID_Подписка = Подписка.ID")
                .Select(payment =>
                {
                    var id = Convert.ToInt32(payment["ID"]);
                    var date = Convert.ToDateTime(payment["ДатаОплаты"]);
                    var idUser = Convert.ToInt32(payment["ID_Пользователь"]);
                    var fio = payment["ФамилияИмя"].ToString();
                    var url = payment["СсылкаНаVK"].ToString();
                    var idSubscription = Convert.ToInt32(payment["ID_Подписка"]);
                    // var subscriptionName = payment["Название"].ToString();
                    var subscription = Subscriptions.GetData().Find(subs => subs.Id == idSubscription);
                    // var queryTypesFromDb = DbConnector.Read("ДоступныйТипЗапроса",
                    //     "Не удалось получить данные о типах запросов для подписки", "*",
                    //     $"WHERE ID_Подписка = {idSubscription}" +
                    //     " LEFT JOIN ТипЗапроса ON ДоступныйТипЗапроса.ID_ТипЗапроса = ТипЗапроса.ID");
                    // var queryTypes = queryTypesFromDb
                    //     .Select(queryType =>
                    //         new QueryType(Convert.ToInt32(queryType["ID_ТипЗапроса"]), queryType["Название"].ToString()))
                    //     .ToList();
                    
                    var sumFromDb = DbConnector.Read("СтоимостьПодписки",
                        "Не удалось получить данные о стоимости подписки", "TOP 1 Стоимость",
                        $"WHERE ID_Подписка = {idSubscription}" +
                        $"AND ДатаДобавленияСтоимости < '{date.ToString(CultureInfo.CurrentCulture)}'" +
                        " ORDER BY ДатаДобавленияСтоимости DESC").ToList();
                    
                    if (sumFromDb.Count > 0)
                    {
                        var sum = Math.Round(Convert.ToDecimal(sumFromDb.ToList()[0]["Стоимость"]), 2);
                        subscription.Sum = sum;
                    }
                    else
                    {
                        subscription.Sum = 0;
                    }

                    return new Payment(id, date, new User(idUser, fio, url), subscription);
                }).ToList();

            return paymentsFromDb;
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        // Дата оплаты
        public DateTime Date { get; set; }

        // Пользователь
        public User User { get; set; }

        // Подписка
        public Subscription Subscription { get; set; }

        public Payment(int id, DateTime date, User user, Subscription subscription)
        {
            Id = id;
            Date = date;
            User = user;
            Subscription = subscription;
        }
    }
}
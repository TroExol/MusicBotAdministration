using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class Subscriptions
    {
        // Список подписок
        private List<Subscription> _subscriptionsList = new List<Subscription>();

        public List<Subscription> SubscriptionsList
        {
            get => _subscriptionsList;
            set
            {
                _subscriptionsList = value;
                // Выполнить делегат при изменении списка
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка
        public event EventHandler OnSet;

        // Делегат при добавлении в список
        public event EventHandler OnAdd;

        public Subscriptions(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление в список
        public void Add(Subscription subscription)
        {
            SubscriptionsList.Add(subscription);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных о подписках
        public static List<Subscription> GetData()
        {
            var subscriptionsFromDb = DbConnector.Read("Подписка",
                    "Не удалось получить данные о подписках")
                .Select(subscription =>
                {
                    var queryTypesFromDb = DbConnector.Read("ДоступныйТипЗапроса, ТипЗапроса",
                        "Не удалось получить данные о типах запросов для подписки",
                        "ID_ТипЗапроса, Название",
                        $"WHERE ДоступныйТипЗапроса.ID_Подписка = {subscription["ID"]}"+
                        " AND ДоступныйТипЗапроса.ID_ТипЗапроса = ТипЗапроса.ID");
                    
                    var queryTypes = queryTypesFromDb
                        .Select(queryType =>
                            new QueryType(Convert.ToInt32(queryType["ID_ТипЗапроса"]),
                                queryType["Название"].ToString()))
                        .ToList();

                    var sumFromDb = DbConnector.Read("СтоимостьПодписки",
                        "Не удалось получить данные о стоимости подписки", "TOP 1 Стоимость",
                        $"WHERE ID_Подписка = {subscription["ID"]} ORDER BY ДатаДобавленияСтоимости DESC")
                        .ToList();

                    decimal sum = 0;
                    if (sumFromDb.Count > 0)
                    {
                        sum = Convert.ToDecimal(sumFromDb.ToList()[0]["Стоимость"]);
                    }

                    var id = Convert.ToInt32(subscription["ID"]);
                    var name = subscription["Название"].ToString();

                    return new Subscription(id, name, sum, queryTypes);
                }).ToList();

            return subscriptionsFromDb;
        }
    }

    public class Subscription
    {
        public int Id { get; set; }

        // Название подписки
        public string Name { get; set; }

        // Стоимость подписки
        public decimal Sum { get; set; }

        // Доступные типы запросов
        public List<QueryType> AvailableQueryTypes { get; set; }

        public Subscription(int id, string name, decimal sum, List<QueryType> availableQueryTypes)
        {
            Id = id;
            Name = name;
            Sum = Math.Round(sum, 2);
            AvailableQueryTypes = availableQueryTypes;
        }
    }
}
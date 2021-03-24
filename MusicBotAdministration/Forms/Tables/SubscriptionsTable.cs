using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MusicBotAdministration.Classes;
using MusicBotAdministration.Forms.EditData;

namespace MusicBotAdministration.Forms.Tables
{
    public partial class SubscriptionsTable : Form
    {
        // Подписки
        private Subscriptions Subscriptions { get; set; }

        // Получение списка подписок
        private List<Subscription> SubscriptionsList
        {
            get => Subscriptions.SubscriptionsList;
            set => Subscriptions.SubscriptionsList = value;
        }

        // Создание таблицы и заголовков
        private static DataTable CreateSubscriptionsTable()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Название", typeof(string)));
            table.Columns.Add(new DataColumn("Стоимость, руб", typeof(decimal)));
            table.Columns.Add(new DataColumn("Доступные типы запросов", typeof(string)));

            return table;
        }

        // Добавление подписок в таблицу и в DataGridView
        private void LoadSubscriptionsTable(object sender, EventArgs e)
        {
            try
            {
                // Создание таблицы
                var table = CreateSubscriptionsTable();

                // Добавление подписок в таблицу
                SubscriptionsList.ForEach((subscription) =>
                {
                    var availableQueryTypes =
                        String.Join("," + Environment.NewLine,
                            subscription.AvailableQueryTypes.Select(queryType => queryType.Name).ToArray());
                    table.Rows.Add(subscription.Id, subscription.Name, subscription.Sum,
                        availableQueryTypes);
                });
                // Добавление источника данных в DataGridView
                generalSubscriptionsTable.DataSource = table;

                // Изменение заголовка DataGridView
                subscriptionsTableLabel.Text = $@"Подписки ({generalSubscriptionsTable.RowCount})";
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить подписки", @"Ошибка");
            }
        }

        public SubscriptionsTable()
        {
            InitializeComponent();

            Subscriptions = new Subscriptions(LoadSubscriptionsTable, LoadSubscriptionsTable);
            SubscriptionsList = Subscriptions.GetData();
        }

        // Добавление подписки
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления подписки
            using (var addSubscriptionForm = new EditSubscription())
            {
                addSubscriptionForm.Text = @"Добавление подписки";
                addSubscriptionForm.addSubscriptionBtn.Text = @"Добавить";

                // Если данные не получены из формы
                if (addSubscriptionForm.ShowDialog() != DialogResult.OK)
                    return;

                var createdAvailableQueryTypes = new List<QueryType>();

                var idSubscription = DbConnector.Create("Подписка",
                    "Название", $"'{addSubscriptionForm.SubscriptionName}'",
                    "Не удалось добавить данные о подписке");

                if (idSubscription != -1)
                {
                    var idSum = DbConnector.Create("СтоимостьПодписки",
                        "Стоимость, ID_Подписка",
                        $"{addSubscriptionForm.Sum}, {idSubscription}",
                        "Не удалось добавить данные о новой стоимости подписки");

                    if (idSum != -1)
                    {
                        addSubscriptionForm.AvailableQueryTypes.ForEach(queryType =>
                        {
                            var id = DbConnector.Create("ДоступныйТипЗапроса",
                                "ID_Подписка, ID_ТипЗапроса",
                                $"{idSubscription}, {queryType.Id}",
                                "Не удалось добавить данные о доступном типе запроса");

                            if (id != -1)
                            {
                                createdAvailableQueryTypes.Add(queryType);
                            }
                        });

                        // Добавление в список
                        Subscriptions.Add(new Subscription(idSubscription, addSubscriptionForm.SubscriptionName,
                            addSubscriptionForm.Sum, createdAvailableQueryTypes));
                    }
                    else
                    {
                        DbConnector.Delete("Подписка", "", $"ID = {idSubscription}");
                    }
                }
            }
        }

        // Изменение подписки
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных подписки
            var selectedSubscriptions = generalSubscriptionsTable.SelectedRows;

            if (selectedSubscriptions.Count != 1)
            {
                MessageBox.Show(@"Выберите 1 подписку", @"Ошибка");
                return;
            }

            // Открытие формы для изменения подписки
            using (var editSubscriptionForm = new EditSubscription())
            {
                editSubscriptionForm.Text = @"Изменение подписки";
                editSubscriptionForm.addSubscriptionBtn.Text = @"Изменить";

                // Получение id выбранной подписки
                var id = Convert.ToInt32(selectedSubscriptions[0].Cells[0].Value);
                // Получение выбранной подписки
                var selectedSubscription = SubscriptionsList.Find((subscription) => subscription.Id == id);

                // Заполнение названия
                editSubscriptionForm.subscriptionNameInput.Text = selectedSubscription.Name;
                // Заполнение стоимости подписки
                editSubscriptionForm.sumInput.Text = selectedSubscription.Sum.ToString(CultureInfo.CurrentCulture);
                // Заполнение доступных типов запросов
                var availableQueryTypesInputLoaded = editSubscriptionForm.availableQueryTypesInput.Items;
                selectedSubscription.AvailableQueryTypes.ForEach(subscription =>
                {
                    editSubscriptionForm.availableQueryTypesInput.SetSelected(
                        availableQueryTypesInputLoaded.IndexOf(subscription.Name), true);
                });
                editSubscriptionForm.AvailableQueryTypes = selectedSubscription.AvailableQueryTypes;

                // Если данные не получены из формы
                if (editSubscriptionForm.ShowDialog() != DialogResult.OK)
                    return;

                var changedName = editSubscriptionForm.SubscriptionName;
                var changedSum = editSubscriptionForm.Sum;
                var changedAvailableQueryTypes = editSubscriptionForm.AvailableQueryTypes;
                var isSubscriptionChanged = false;
                var idCreatedCost = -1;
                var newAvailableQueryTypes = editSubscriptionForm.AvailableQueryTypes;

                if (selectedSubscription.Name != changedName)
                {
                    isSubscriptionChanged = DbConnector.Update("Подписка", $"Название = '{changedName}'",
                        "Не удалось изменить название подписки",
                        $"ID = {selectedSubscription.Id}");
                }

                if (selectedSubscription.Sum != changedSum)
                {
                    idCreatedCost = DbConnector.Create("СтоимостьПодписки",
                        "Стоимость, ID_Подписка",
                        $"{changedSum}, {selectedSubscription.Id}",
                        "Не удалось изменить стоимость подписки");
                }

                if (!Misc.ListsAreEqual(selectedSubscription.AvailableQueryTypes, changedAvailableQueryTypes))
                {
                    var toDelete = selectedSubscription.AvailableQueryTypes.Where(queryType =>
                        !changedAvailableQueryTypes.Exists(changedQueryType =>
                            changedQueryType.Id == queryType.Id)).ToList();
                    var toCreate = changedAvailableQueryTypes.Where(changedQueryType =>
                        !selectedSubscription.AvailableQueryTypes.Exists(queryType =>
                            changedQueryType.Id == queryType.Id)).ToList();

                    toDelete.ForEach(queryType =>
                    {
                        var isDeleted = DbConnector.Delete("ДоступныйТипЗапроса", "",
                            $"ID_ТипЗапроса = {queryType.Id} AND ID_Подписка = {selectedSubscription.Id}");

                        if (!isDeleted)
                        {
                            newAvailableQueryTypes.Add(queryType);
                        }
                    });

                    toCreate.ForEach(queryType =>
                    {
                        var idCreate = DbConnector.Create("ДоступныйТипЗапроса",
                            "ID_Подписка, ID_ТипЗапроса",
                            $"{selectedSubscription.Id}, {queryType.Id}", "");

                        if (idCreate == -1)
                        {
                            newAvailableQueryTypes.RemoveAt(
                                changedAvailableQueryTypes
                                    .FindIndex(findQueryType => findQueryType.Id == queryType.Id)
                            );
                        }
                    });
                }

                // Изменение подписки
                SubscriptionsList = SubscriptionsList.Select((subscription) =>
                {
                    if (subscription.Id == id)
                    {
                        if (isSubscriptionChanged)
                        {
                            subscription.Name = changedName;
                        }

                        if (idCreatedCost != -1)
                        {
                            subscription.Sum = changedSum;
                        }

                        subscription.AvailableQueryTypes = newAvailableQueryTypes;

                        if (!Misc.ListsAreEqual(changedAvailableQueryTypes, newAvailableQueryTypes))
                        {
                            MessageBox.Show(@"Не удалось изменить весь список доступных типов запросов",
                                @"Предупреждение");
                        }
                    }

                    return subscription;
                }).ToList();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class Users
    {
        // Список пользователей
        private List<User> _usersList = new List<User>();

        public List<User> UsersList
        {
            get => _usersList;
            set
            {
                _usersList = value;
                // Выполнить делегат при изменении списка
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка
        public event EventHandler OnSet;

        // Делегат при добавлении данных в список
        public event EventHandler OnAdd;

        public Users(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление данных в список
        public void Add(User user)
        {
            UsersList.Add(user);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных о пользователях
        public static List<User> GetData()
        {
            var usersFromDb = DbConnector.Read("Пользователь",
                    "Не удалось получить данные о пользователях")
                .Select(user =>
                {
                    var id = Convert.ToInt32(user["ID"]);
                    var fio = user["ФамилияИмя"].ToString();
                    var url = user["СсылкаНаVK"].ToString();
                    
                    return new User(id, fio, url);
                }).ToList();

            return usersFromDb;
        }
    }

    public class User
    {
        public int Id { get; set; }

        // ФИО пользователя
        public string FIO { get; set; }

        // Ссылка на пользователя в VK
        public string Url { get; set; }

        public User(int id, string fio, string url)
        {
            Id = id;
            FIO = fio;
            Url = url;
        }
    }
}
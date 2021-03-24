using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MusicBotAdministration.Classes
{
    public static class DbConnector
    {
        private const bool DEBUG = true;
        private const string ConnectionString =
            @"Data Source=localhost;Initial Catalog=MusicBotAdministration;Integrated Security=True";

        /// <summary>
        /// Добавление записи в таблицу БД
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="columns">Колонки</param>
        /// <param name="values">Значения</param>
        /// <param name="messageError">Сообщение об ошибке. По умолчанию выводится дефолтное сообщение</param>
        /// <returns>Id новой записи</returns>
        public static int Create(string tableName, string columns, string values, string messageError = null)
        {
            var connection = new SqlConnection {ConnectionString = ConnectionString};
            var index = -1;

            try
            {
                connection.Open();
                var sqlCommand =
                    new SqlCommand($"INSERT INTO {tableName} ({columns}) OUTPUT INSERTED.ID VALUES ({values})",
                        connection);

                index = (int) sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                if (DEBUG)
                {
                    MessageBox.Show(e.Message);
                }
                if (messageError != "")
                {
                    MessageBox.Show(messageError ?? @"Не удалось добавить запись в базу данных", @"Ошибка");
                }
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }

            return index;
        }

        /// <summary>
        /// Получение данных из БД
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="messageError">Сообщение об ошибке. По умолчанию выводится дефолтное сообщение</param>
        /// <param name="select">Какие столбцы получить. По умолчанию *</param>
        /// <param name="parameters">Фильтры, сортировки, join'ы и прочее. По умолчанию пустая строка</param>
        /// <returns>Полученные записи</returns>
        public static IEnumerable<Dictionary<string, object>> Read(string tableName, string messageError = null,
            string select = "*", string parameters = "")
        {
            var result = new List<Dictionary<string, object>>();
            var connection = new SqlConnection {ConnectionString = ConnectionString};

            try
            {
                connection.Open();
                var sqlCommand = new SqlCommand($"SELECT {select} FROM {tableName} {parameters}", connection);

                using (var userData = sqlCommand.ExecuteReader())
                {
                    var columns = Enumerable.Range(0, userData.FieldCount).Select(userData.GetName).ToList();

                    while (userData.Read())
                    {
                        var dictionary = new Dictionary<string, object>();

                        columns.ForEach(column => { dictionary.Add(column, userData[column]); });

                        result.Add(dictionary);
                    }
                }
            }
            catch (Exception e)
            {
                if (messageError == "DEBUG" || DEBUG)
                {
                    MessageBox.Show(e.Message);
                }
                if (messageError != "" && messageError != "DEBUG")
                {
                    MessageBox.Show(messageError ?? @"Не удалось получить данные из базы данных", @"Ошибка");
                }
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Обновление записей в БД
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="set">Устанавливаемые значения</param>
        /// <param name="messageError">Сообщение об ошибке. По умолчанию выводится дефолтное сообщение</param>
        /// <param name="filter">Фильтр</param>
        public static bool Update(string tableName, string set, string messageError = null, string filter = null)
        {
            var connection = new SqlConnection {ConnectionString = ConnectionString};
            var success = false;
            
            try
            {
                connection.Open();
                var sqlCommand =
                    new SqlCommand($"UPDATE {tableName} SET {set} {(filter != null ? $"WHERE {filter}" : "")}",
                        connection);

                sqlCommand.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                if (DEBUG)
                {
                    MessageBox.Show(e.Message);
                }
                if (messageError != "")
                {
                    MessageBox.Show(messageError ?? @"Не удалось обновить записи в базе данных", @"Ошибка");
                }
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }

            return success;
        }

        /// <summary>
        /// Удаление записей из БД
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="messageError">Сообщение об ошибке. По умолчанию выводится дефолтное сообщение</param>
        /// <param name="filter">Фильтр</param>
        public static bool Delete(string tableName, string messageError = null, string filter = null)
        {
            var connection = new SqlConnection {ConnectionString = ConnectionString};
            var success = false;
            
            try
            {
                connection.Open();
                var sqlCommand =
                    new SqlCommand($"DELETE FROM {tableName} {(filter != null ? $"WHERE {filter}" : "")}",
                        connection);

                sqlCommand.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                if (DEBUG)
                {
                    MessageBox.Show(e.Message);
                }
                if (messageError != "")
                {
                    MessageBox.Show(messageError ?? @"Не удалось удалить записи из базы данных", @"Ошибка");
                }
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }

            return success;
        }
        
        /// <summary>
        /// Выполнение запросы
        /// </summary>
        /// <param name="sqlString">Строка SQL запроса</param>
        /// <param name="messageError">Сообщение об ошибке. По умолчанию выводится дефолтное сообщение</param>
        /// <returns></returns>
        public static bool Execute(string sqlString, string messageError = null)
        {
            var connection = new SqlConnection {ConnectionString = ConnectionString};
            var success = false;
            
            try
            {
                connection.Open();
                var sqlCommand = new SqlCommand(sqlString, connection);

                sqlCommand.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                if (DEBUG)
                {
                    MessageBox.Show(e.Message);
                }
                if (messageError != "")
                {
                    MessageBox.Show(messageError ?? @"Не удалось выполнить запрос", @"Ошибка");
                }
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }

            return success;
        }
    }
}
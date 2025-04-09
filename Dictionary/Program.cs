using System;
using System.Collections.Generic;

namespace Dictionary
{
    class App
    {
        public static void Main()
        {


            /*
             * Все совпадения с реальными людьми случайны
             * За кринж ответственен яндекс gpt
             */




            #region Создание книжной полки
            var books = new Dictionary<int, string>
            {
                {1, "Война и мир"},
                {2, "Мастер и Маргарита"},
                {3, "Код без багов за 5 минут"}
            };
            #endregion


            #region Пишем книгу вместе
            books.Add(4, "Стать миллионера очень просто всего-то надо... читать дальше");
            #endregion


            #region Церемония сожжения книг или как удалить значение из словаря
            Console.WriteLine("Сжигаем том 'Войны и мира'...");
            books.Remove(1); // Толстой плачет в раю
            Console.WriteLine("Толстому можно писать 4 тома, а нам нельзя удалить одну запись? 😡");
            #endregion

            #region Обновляем Никиту (потому что можем)
            var ages = new Dictionary<string, int> { { "Никита", 12 } };
            ages["Никита"] = 13; // Секретная технология: ДР
            Console.WriteLine("\nНикита теперь на год ближе к армии");
            #endregion

            #region Книжный магистр-класс
            // При попытке доступа по ключу, которого нет, вылезает ошибочка KeyNotFoundException
            // Вот один из вариантов решение
            try
            {
                Console.WriteLine($"\nЧитаем книгу: {books[3]}");
                Console.WriteLine("Ой, эта книга пустая. Все баги сбежали!");
            }
            catch
            {
                Console.WriteLine("Книга испарилась. Видимо, её написал призрак");
            }
            // Вот второй
            if (books.ContainsKey(3))
            {
                /* { ... } */
            }
            #endregion

            #region Студенческий цирк
            // Чтобы узнать кто такой студент листай вниз

            // Когда делаете словарь с классами:
            // 1. Ключ должен быть простым (как ID студента, любой базовый неизменяемый тип данных, например int,
            // string, но не float и не double, там сликом много знаков, и в зависимости от версии ядра компилятора
            // результат может быть разным)
            // 2. Значения могут быть хоть слонами (главное, чтобы ключи не повторялись)

            var students = new Dictionary<int, Student>
            {
                {1, new Student("Вася", 2.5)},
                {2, new Student("Маша", 5.0)}
            };

            // Попытка найти студента с баллом 4.9
            Console.WriteLine("\nПоиск идеального студента:");
            foreach (var student in students)
            {
                if (student.Value.AvgGrade > 4.9)
                {
                    Console.WriteLine($"{student.Value.Name} - почти отличник (но это не точно)");
                }
            }
            #endregion
        }
    }

    #region Класс для жертв ЕГЭ
    public record Student(string Name, double AvgGrade);

    // record это упрощённое написание следущего кода

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public double AvgGrade { get; set; }

    //    public Student(string name, double avgGrade)
    //    {
    //        Name = name;
    //        AvgGrade = avgGrade;
    //    }
    //}
    #endregion
}
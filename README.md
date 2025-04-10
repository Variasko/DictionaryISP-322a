**1. Учет книг (Легкое)**  
Создайте словарь для учета книг (название → год издания).  
Попросите пользователя ввести 3 книги через консоль (название и год через пробел), затем выведите весь список.  
*Пример: "ВойнаИМир 1869"*

**2. Удаление персонажей (Легкое)**  
Словарь: `Dictionary<string, string> characters = new() { {"Леголас", "Эльф"}, {"Гендальф", "Маг"} }`  
Пользователь вводит имя персонажа для удаления. Если его нет — выведите: "Персонаж не найден!".

**3. Лучший игрок (Легкое)**  
Дан словарь: `Dictionary<string, int> players = new() { {"Алексей", 150}, {"Мария", 200} }`  
Найдите и выведите имя игрока с максимальным количеством очков.

**4. Частота слов (Легкое)**  
Пользователь вводит слова. Подсчитайте их частоту (слово → количество повторений). Выведите статистику.  
*Пример: "Привет" → 3 раза.*

**5. Случайная цитата (Легкое)**  
Словарь: `Dictionary<string, string> quotes = new() { {"Жизнь как велосипед...", "Эйнштейн"}, {"Будь собой...", "Неизвестно"} }`  
При запуске выводите случайную цитату с автором.

**6. Сленг-переводчик (Среднее)**  
Словарь: `Dictionary<string, string> slang = new() { {"Криптовалюта", "Монета"}, {"Сервер", "Борщ"} }`  
Пользователь вводит слово — выводите сленговый аналог. Если нет — "Неизвестное слово".

**7. Фильтр студентов (Среднее)**  
Словарь: `Dictionary<string, double> students = new() { {"Иван", 4.5}, {"Ольга", 3.8} }`  
Выведите студентов со средним баллом выше значения, которое введет пользователь.

**8. Средний балл (Среднее)**  
Создайте словарь (студент → список оценок). Пользователь вводит оценки, выведите средний балл для каждого.  
*Пример: "Иван 5 4 5" → Среднее: 4.67.*

**9. Шифратор гласных (Среднее)**  
Словарь для шифра: `{{'а', '#'}, {'о', '*'}, ...}`  
Пользователь вводит слово — программа заменяет гласные на символы из словаря.

**10. Генератор псевдонимов (Среднее)**  
Словари: `прилагательные = ["Яростный", "Летучий"]`, `существительные = ["Огурец", "Стул"]`  
При запуске объединяйте случайные пары: *"ЯростныйОгурец"*.

**11. Угадай автора (Сложное)**  
Словарь: `Dictionary<string, string> quotes = new() { {"To be or not to be", "Шекспир"}, {"Я мыслю — значит существую", "Декарт"} }`  
Программа выбирает случайную цитату. У пользователя 3 попытки угадать автора.

**12. Конвертер криптовалют (Сложное)**  
Словарь: `Dictionary<string, double> crypto = new() { {"BTC", 2_500_000}, {"ETH", 150_000} }`  
Пользователь вводит сумму и валюту (например: "0.5 BTC") — программа конвертирует в рубли.

**13. Объединение контактов (Сложное)**  
Пользователь вводит два телефонных справочника (имя → номер). Объедините их. При совпадении имен оставьте номер из второго справочника.

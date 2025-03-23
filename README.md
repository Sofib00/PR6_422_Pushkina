#Практическая работа 6 (1 часть) Пушкина 422
Этот проект представляет собой тестирование класса `BankAccount` с использованием модульных тестов в Microsoft Visual Studio. 
Тестирование проводится методом "белого ящика" с применением MSTest.
## Структура проекта
- `BankAccount.cs` — основной класс банковского счета.
- `BankAccountTests.cs` — тестовый класс с модульными тестами.
## Результаты тестирования
- Тест `Debit_WithValidAmount_UpdatesBalance` пройден успешно.
- Тест `Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange` пройден успешно.
- Тест `Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange` пройден успешно.
- Тесты для метода `Credit_WhenAmountIsNegative_ShouldThrowArgumentOutOfRange` выполнены успешно.
- Тесты для метода `Credit_WithPositiveAmount_UpdatesBalance` выполнены успешно.
## Исправленные ошибки
- В методе `Debit` исправлена ошибка, при которой сумма списания добавлялась к балансу вместо вычитания.
- Улучшена обработка исключений `ArgumentOutOfRangeException` с уточняющими сообщениями.
## Вывод
Все тесты успешно пройдены, корректная работу методов `Debit` и `Credit`. Процесс модульного тестирования помог исправить ошибку в методе `Debit`.
![результат работы приложения](C:\Users\Пользователь\OneDrive\Изображения\Снимки экрана)
![окнj «Обозреватель тестов»](C:\Users\Пользователь\OneDrive\Изображения\Снимки экрана)

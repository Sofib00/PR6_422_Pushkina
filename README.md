# Практическая работа 6 (1 часть) Пушкина 422
Этот проект представляет собой тестирование класса `BankAccount` с использованием модульных тестов в Microsoft Visual Studio. 
Тестирование проводится методом "белого ящика" с применением MSTest.
## Структура проекта
- `BankAccount.cs` — основной класс банковского счета.
- `BankAccountTests.cs` — тестовый класс с модульными тестами.
## Результаты тестирования
- Тест `Debit_WithValidAmount_UpdatesBalance` пройден успешно.
- Тест `Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange` пройден успешно.
- Тест `Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange` пройден успешно.
- Тест `Credit_WhenAmountIsNegative_ShouldThrowArgumentOutOfRange` выполнен успешно.
- Тест `Credit_WithPositiveAmount_UpdatesBalance` выполнен успешно.
## Исправленные ошибки
- В методе `Debit` исправлена ошибка, при которой сумма списания добавлялась к балансу вместо вычитания.
- Улучшена обработка исключений `ArgumentOutOfRangeException` с уточняющими сообщениями.
## Вывод
Все тесты успешно пройдены, корректная работу методов `Debit` и `Credit`. Процесс модульного тестирования помог исправить ошибку в методе `Debit`.

![результат работы приложения](https://github.com/user-attachments/assets/b6840245-fcae-47f2-b7fb-2e94d2cea8df)

![окно «Обозреватель тестов»](https://github.com/user-attachments/assets/e99b4041-ba1f-4153-9011-806a69ba10db)

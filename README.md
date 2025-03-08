# DataBase_App

## Описание проекта
**DataBase_App** — это WinForms-приложение для работы с базой данных PostgreSQL. Оно позволяет управлять записями клиентов и их регистрациями на тренировки в спортивном центре.

## Функциональность
- Подключение к базе данных PostgreSQL
- Управление регистрациями (`SignUp`):
  - Загрузка списка регистраций
  - Добавление новой регистрации
  - Редактирование существующей регистрации
  - Удаление регистрации
- Управление клиентами (`Client`):
  - Загрузка списка клиентов
  - Добавление нового клиента
  - Редактирование данных клиента
  - Удаление клиента
- Взаимодействие с таблицами `Client`, `SignUp`, `Training` и `Season_ticket`

## Используемые технологии
- **C#**, **WinForms**
- **PostgreSQL**, **Npgsql**
- **ADO.NET** (для работы с БД)

## Требования для запуска
- .NET Framework (или .NET Core, если используется)
- PostgreSQL сервер
- Библиотека **Npgsql** (добавляется через NuGet)

## Настройка проекта
1. Установите PostgreSQL и создайте базу данных.
2. Добавьте таблицы `Client`, `SignUp`, `Training`, `Season_ticket` (структура БД должна соответствовать запросам в коде).
3. Укажите корректные параметры подключения в коде.
4. Соберите и запустите проект.



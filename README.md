# Руководство по Electric Shop
## О проекте
Приложение написано на 3 курсе колледжа как внутренняя практика, в течении недели по выданному заданию реализовать базовый магазин электротехники c CRUD операциями и БД для сохранения данных о товарах.

## Используемые технологии
+ С# - основной язык программирования на котором написан проект;
+ WinForms - Интерфейс программирования приложения на нем весь UI выполнен;
+ MS SQL - База Данных которая использовалась по заданию для хранения данных;
+ SQL - язык запросов для взаимодействия приложения с БД.

## Запуск проекта
> Для начала вам нужно установить **Visual Studio** [Здесь вы можете скачать Visual Studio Последней версии](https://visualstudio.microsoft.com/ru/ "Microsoft сайт для установки VS2022") <br>
**MSSQL** [Как установить MS SQL Последней версии вы можете узнать здесь](https://learn.microsoft.com/ru-ru/ssms/install/install?view=aps-pdw-2016-au7&tabs=command-line "Инструкция по установке MSSQL от Microsoft")

После их установки вы сможете клонировать данный репозиторий нажав:
* Кнопка Code -> Опция из меню Open with Visual Studio -> Готово вы клонировали репозиторий;
* В папке проекта берем файл script.sql -> Открываем его с помощью MSSQL -> Запускаем его исполнение.

Теперь остается лишь изменить под вас одну строку подключения к БД в файле DataBase.cs
``` C#
SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GPMHDR2\SQLEXPRESS;Initial Catalog=SystemShop;Integrated Security=True");
```
Здесь вы должны заменить @"Data Source=___; - на название своей БД MSSQL.<br>
Готово теперь вы можете пользоваться приложение!

## Показ запущенного приложения
<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20173912.png" alt="Окно Авторизации"> 
</p>
<p align="center">Картинка 1 - Окно Авторизации.</p><br>

<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20173912.png" alt="Окно Регистрации"> 
</p>
<p align="center">Картинка 2 - Окно Регистрации.</p><br>

<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20174021.png" alt="Окно Авторизации Заполненное"> 
</p>
<p align="center">Картинка 3 - Окно Регистрации Заполненное данными.</p><br>

<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20174224.png" alt="Окно Главного Экрана"> 
</p>
<p align="center">Картинка 4 - Окно Главного Экрана Товаров.</p><br>

<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20174857.png" alt="Окно Заказанных Товаров"> 
</p>
<p align="center">Картинка 5 - Окно Заказанных Товаров.</p><br>

<p align="center">
    <img src="https://github.com/Vorashi/Electric-Shop/blob/master/mainPage/ReadMeResources/Screenshot%202025-06-09%20175338.png" alt="Окно Добавления Товаров"> 
</p>
<p align="center">Картинка 6 - Окно Добавления Товаров.</p><br>

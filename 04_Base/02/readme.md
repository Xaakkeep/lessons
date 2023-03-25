# Домашняя работа

## Урок 2. Работа с данными из разных таблиц

+ Чему будет равна выборка:
+ [Таблица на гугл диске](https://docs.google.com/spreadsheets/d/1U_b_5STw5R66dX11CDcRjKcUc13pmPDtRW1w02Ek90E/edit?usp=sharing)

1. SELECT ФИО, Д/р, Адрес FROM Общий список
![Task 01-01](Task01-01.png)
2. SELECT ФИО, Статус FROM Общий список WHERE Адрес = «Можга»
![Task 01-02](Task01-02.png)
3. SELECT ФИО FROM Общий список WHERE Адрес = «Москва» AND Группа = «Работа»
![Task 01-03](Task01-03.png)
4. SELECT Д/р FROM Общий список WHERE Адрес = «Москва» OR Группа = «Работа»
![Task 01-04](Task01-04.png)

+ Что будет результатом следующих JOIN’ов:

1. INNER JOIN Люди, Адреса ON id = Чей адрес
![Task 02-01](Task02-01.png)
2. LEFT JOIN Люди, Адреса ON id = Чей адрес
![Task 02-02](Task02-02.png)
3. RIGHT JOIN Люди, Адреса ON id = Чей адрес
![Task 02-03](Task02-03.png)
4. FULL JOIN Люди, Адреса ON id = Чей адрес
![Task 02-04](Task02-04.png)

+ Дополнительное задание. Что будет результатом выборки:

+ SELECT ФИО, Адрес, Комментарий FROM Люди RIGHT JOIN Адреса ON id = Чей Адрес
![Task 03](Task03.png)

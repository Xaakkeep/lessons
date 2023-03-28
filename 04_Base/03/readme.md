# Домашняя работа

## Урок 3. Создание структуры базы данных

Опишите базу данных для школьного кабинета, в рамках которой можно фиксировать, кто и в какое время сидел за той или иной партой.

[Таблица](https://docs.google.com/spreadsheets/d/1U_b_5STw5R66dX11CDcRjKcUc13pmPDtRW1w02Ek90E/edit?usp=sharing)

+ — Место ученика — это ряд, парта, вариант.
+ — В течение одного дня у разных классов бывает несколько уроков.
+ — Создайте минимум 3 таблицы: «Кабинет», «Ученик» и сводная таблица, где отображаются парты и ученики.
+ — Используйте поля «началоурока» и «конецурока» с типом данных TimeStamp.

### Таблица Ученики

![id_student](id_student.png)

+ Описание таблицы

![id_student](id_student_description.png)

### Таблица Классы

![id_class](id_class.png)

+ Описание таблицы

![id_class](id_class_description.png)

### Таблица Кабинет

![id_cabinet](id_cabinet.png)

+ Описание таблицы

![id](id_cabinet_description.png)

### Таблица Место ученика

![id_desk](id_desk.png)

+ Описание таблицы

![id_desk](id_desk_description.png)

### Сводная таблица

![Base](Base.png)

+ Описание таблицы

![Base](Base_description.png)

### Полная сводная таблица

![Base_Full](Base_full.png)

# HeroGame_TeamX
Учебный репозиторий по игре про героев.

#### Участники:
+ [*Меленчук Алексей*](https://github.com/XMelexus) - **CAPTAIN**
+ [*Исува Джоэл*](https://github.com/JoeFreedom)
+ [*Саранцев Дмитрий*](https://github.com/Sar-dim)
+ [*Судаков Владимир*](https://github.com/Vladimir233)

# Классы.

##**1. Hero**

### Описание:
***Данный класс является абстрактным. Классы новых персонажей ***
***обязательны должны наследоватьс этот класс ***

### Члены:
+ **MAX_STAMINA** - ***Максимальная выносливость персонажа ***
+ **MAX_MANA** - ***Максимальная мана персонажа***
+ **MAX_HEALTH** - ***Максимальное здоровье персонажа***
+ **Name** - ***Имя персонажа***
+ **CurrentHealth** - ***Текущее здоровье персонажа***
+ **CurrentStamina** - ***Текущая выносливость персонажа***
+ **CurrentMana** - ***Текущая мана персонажа***
+ **IsAlive** - ***Жив ли персонаж?***
+ **Race** - ***Раса персонажа***
+ **Proffesion** - ***Профессия персонажа***
+ **Strength** - ***Сила персонажа***
+ **Agility** - ***Ловкость персонажа***
+ **Intelligence** - ***Интеллект персонажа***
+ **Endurance** - ***Стойкость персонажа***
+ **BasedDamage** - ***100% урон персонажа без учёта оружий***
+ **Inventory** - ***Инвентарь персонажа***

### Методы:
+ **string InflictDamage(Hero anotherHero)** - ***Нанести урон другому персонажу. Возвращает информацию об ударе***
+ **string InflictMagicDamage(Hero anotherHero)** - ***Нанести магический урон другому персонажу. Возвращает информацию об ударе*** 
+ **void DecreaseHealth/IncreaseHealth(double amountHealth)** - ***Отнимает/прибавляет здоровье***
+ **void DecreaseStamina/IncreaseStamina(double amountStamina)** - ***Отнимает/рибавляет выносливость***
+ **void DecreaseMana/IncreaseMana(double amountMana)** - ***Отнимает/прибавляет ману ***

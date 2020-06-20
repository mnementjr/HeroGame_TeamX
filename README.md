
# HeroGame_TeamX
Учебный репозиторий по игре про героев.

#### Участники:
+ [*Меленчук Алексей*](https://github.com/XMelexus) - **CAPTAIN**
+ [*Исува Джоэл*](https://github.com/JoeFreedom)
+ [*Саранцев Дмитрий*](https://github.com/Sar-dim)
+ [*Судаков Владимир*](https://github.com/Vladimir233)

# Классы.

## **1. Hero**

### Описание:
***Данный класс является абстрактным. Классы новых персонажей***
***обязательны должны наследоватьс этот класс***

### Члены:
+ **double MAX_STAMINA** - ***Максимальная выносливость персонажа***
+ **double MAX_MANA** - ***Максимальная мана персонажа***
+ **double MAX_HEALTH** - ***Максимальное здоровье персонажа***
+ **string Name** - ***Имя персонажа***
+ **double CurrentHealth** - ***Текущее здоровье персонажа***
+ **double CurrentStamina** - ***Текущая выносливость персонажа***
+ **double CurrentMana** - ***Текущая мана персонажа***
+ **bool IsAlive** - ***Жив ли персонаж?***
+ **RaceType Race** - ***Раса персонажа***
+ **ProffesionType Proffesion** - ***Профессия персонажа***
+ **double Strength** - ***Сила персонажа***
+ **double Agility** - ***Ловкость персонажа***
+ **double Intelligence** - ***Интеллект персонажа***
+ **double Endurance** - ***Стойкость персонажа***
+ **double BasedDamage** - ***100% урон персонажа без учёта оружий***
+ **Inventory Inventory** - ***Инвентарь персонажа***

### Методы:
+ **string InflictDamage(Hero anotherHero)** - ***Нанести урон другому персонажу. Возвращает информацию об ударе***
+ **string InflictMagicDamage(Hero anotherHero)** - ***Нанести магический урон другому персонажу. Возвращает информацию об ударе*** 
+ **void DecreaseHealth/IncreaseHealth(double amountHealth)** - ***Отнимает/прибавляет здоровье***
+ **void DecreaseStamina/IncreaseStamina(double amountStamina)** - ***Отнимает/рибавляет выносливость***
+ **void DecreaseMana/IncreaseMana(double amountMana)** - ***Отнимает/прибавляет ману***

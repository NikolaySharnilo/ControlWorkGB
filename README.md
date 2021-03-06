# Описание алгоритма работы программы

## Задача
Написать программу, котрая из имещегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с квалиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения
Решено выделить программу в отдельный метод. 
На вход принимается массив из строк и число символов для выборки.

*Шаги работы программы:*
1. Объявляется переменная **count** типа int для подсчета количества подходящих под условия элементов
2. Проходим циклом по входящему массиву, проверяем длину каждого элемента на соответствие нужному количеству символов. В случаи совпадения условий к **count** добавляется 1.
3. Создаем новый массив с длинной **count**.
4. Объявляем переменную **a** типа int, далее она будет использована как счетчик для записи в новый массив.
5. Повторяем проход по входящему массиву, как в шаге 2, но в случаи совпадения условия записываем в новый массив значение из входящего массива и добавляем к **a** + 1.
6. Возвращаем вновь заполненный массив.

## Примечание
Для удобства просмотра результатов работы алгоритма добавлен метод PrintArray, который выводит в консоль передаваемый массив.

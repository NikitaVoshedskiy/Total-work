## Задача:
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []

## Решение
1. Задаем длинну массива, после чего задаем сам массив.
2. Вызываем метод для заполнения нашего массива элементами. Выводим получившийся массив.
3. Вызываем метод для расчета длинны нашего будущего массива (ArrayNew) за счет ранее прописанного массива. Метод заключается в том, что идет проверка на длинну каждого элемента ранее написанного массива (ArrayOld). Длинна элемента не должна превышать трех символов. После прохождения метода выводим число, равное длинне будущего массива (ArrayNew).
4. Задаем новый массив длинной равною числу, получившемуся в методе под пунктом 3.
5. Вызываем метод где в новый массив заносятся значения которые проходят проверку на длинну элемента (меньше 4). Выводим новый массив.

Блок-схема алгоритма добавлена также в проект.

Решение задачи находится в папке KR, в файле Program.cs.
## Дано следующее задание, которое разбито по пунктам:

- Создать репозиторий на GitHub.

- Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод).

- Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
- Написать программу, решающую поставленную задачу.

- Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).

---

Сама задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Пример:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

---

Решение:

1. Вначале мы создаем переменную "int num", в которой записываем натуральное число, введенное пользователем. Данное число будет указывать сколько элементов у нас будет в массиве.

2. После этого создаем рабочий массив "string[] array" в котором будет необходимое количество элементов. Для этого, мы через цикл "for", просим пользователя ввести сам элемент (или элементы, в зависимости какую цифру ввел пользователь выше). Наш счетчик ("arrayLength" будет учитывать только те эллементы, количество символов которорых равна или меньше 3).

3. Далее у нас срабатывает условие if ("arrayLength > 0"), то есть имеется элемент удовлетворяющий условиям (символы <=3). Если таковые есть, то мы их находим и перечисляем через цикл for (20 строка), а так же выводим на печать экрана с указанием значений элемента.

4. Если наше условие (if) не срабатывает, то есть нет элементов удовлетворяющих условиям (символы <=3). Тогда переходим к альтернативному условию "else", где указываем пользователю, что таких элементов нет.

5. Ссылка на репозиторий: https://github.com/MichaelKuch26/final_homework_1

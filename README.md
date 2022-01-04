# Задачи с собеседований

  Проходя собеседования в разных компниях начал собирать подборку задач которые задают,
свои решения предлагаю вашему вниманию.

Cреда разработки MS VS 2017 C#. Проект каждой задачи в отдельном  каталоге

1) ЗадачаЧислоПалиндром 

     Напишите программу, которая составляет из цифр введённой строки число-палиндром 
      (которое читается одинаково слева направо и справа налево). 
  
  Решение задачи выполнено WPF с соблюдением MVVM

![Image Alt](s1.png)


Следующие задачи выполнены среда разработки MS VS 2010 C# Express.  

 
2) Test01  - самая легкая задача, стоимость тары, даже комментировать не чего

![Image Alt](1.png)

 

3) Test02test  - эта уже чуть посложней , расчитать угол между часовой и минутной стрелкой

  Примерно так - на циферблате 60 минутных делений? значит 1 минутное деление =  [360/60] Градусов , а также минутные деления еще помечены как часовые (каждое 5-е деление) т.е. 12 часовых секторов лежат на 60 минутных делениях, и 1 часовой сектор занимает 5 минутных делений или 30 Градусов.
  Определившись с этим дальнейшее решение заключается в том что бы подсчитать
  Значит минутная стрелка пройдя минуту протащит часовую стрелку на 

![Image Alt](2.png)
в этом решении у меня ошибка.



еще нерешенные

Задание 1
Дан массив [3279, 920, 4181, 8, 337, 13, 918, 4923, 4448, 8, 4756, 4012, 7467, 89, 21, 2400, 4409, 6005, 3172, 55, 5, 6367, 8, 9970, 144, 1, 4360, 407, 7010, 9160, 7149, 9038, 9196, 8625, 662, 1597, 21, 2592, 1597, 5424, 2584, 2937, 1597, 9835, 7960, 2254, 3531, 8034, 9393, 807, 3225, 6765, 399, 3230, 34, 153, 2, 3980, 2093, 9238, 2326, 6453, 89, 4606, 3413, 3, 9950, 2098, 8579, 4914, 7204, 8875]. Среди его ячеек некоторые числа являются числами Фибоначчи (числами, учавствующимив последовательности Фибоначчи: 1, 1, 2, 3, 5, 8, 13, 21). Найдите сумму чисел Фибоначчи в этом массиве.
 
Задание 2
Возьмите любую картинку , без использования сторонних библиотек анализа изображений, найдите самый распространенный цвет на этом изображении. Выведите его в формате #FFFFFF
 
Задание 3
Даны два одномерных массива:
$first = [1, 212, 3876, 481, 75, 36, 24, 76, 81, 2734, 6751, 53, 76, 4512, 364, 51826, 374, 61, 93, 26, 4517, 26, 3, 5, 4, 1, 23465, 851, 56253, 76, 41, 783, 26, 9461, 238, 674, 51, 95, 2, 39764];
$second = [7638, 2710, 4157, 82, 36017, 6397562, 93, 47, 519, 037985, 716038, 479176, 345872, 653486, 53, 48, 652, 9, 7, 4369278, 36, 48576, 2934765, 62973, 645, 62, 5364, 9, 7, 562, 9387, 465, 927346, 957, 2364, 9572, 69347, 956];
 
Найдите во втором массиве самое маленькое число, большее, чем среднеарифметическое значение всех элементов первого массива.





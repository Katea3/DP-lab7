using System;
using System.Diagnostics;

class Maximum
{
    static void Main()
    {
        // Исходный массив чисел
        int[] a = [1, 2, 3, 4, 5, 7];

        // Вызов функции поиска максимума
        int max = FindMax(a);

        // Вывод результата
        Console.WriteLine(max);
    }

    // Функция поиска максимального элемента массива
    static int FindMax(int[] a)
    {
        // Проверка, что массив не пустой
        Debug.Assert(a.Length > 0);

        // Предполагаем, что первый элемент – максимальный
        int maximum = a[0];

        // Перебираем оставшиеся элементы массива
        for (int i = 1; i < a.Length; i++)
        {
            // Если текущий элемент больше найденного максимума — обновляем значение
            if (a[i] > maximum)
            {
                maximum = a[i];
            }
        }

        // Возвращаем найденное максимальное значение
        return maximum;
    }
}

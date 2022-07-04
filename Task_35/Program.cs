/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат
в отрезке [10, 99]*/

int[] array = new int[123];

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(1, 200);
    Console.Write(array[i] + " ");
}

int count = 0;

for (int i = 0; i < array.Length; i++) {
    if (array[i] >= 10 & array[i] <= 99) {
        count += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Number of items between 10 and 99 is {count}");
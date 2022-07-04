/* Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
элементов массива*/

int[] array = new int [12];
int negativeSum = 0;
int positiveSum = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-9, 10);

    if (array[i] > 0) {
        positiveSum = positiveSum + array[i];
    }
    if (array[i] < 0) {
        negativeSum = negativeSum + array[i];
    }
    Console.WriteLine(array[i] + " ");
}

Console.WriteLine($"Sum of positive numbers is {positiveSum}");
Console.WriteLine($"Sum of negative numbers is {negativeSum}");


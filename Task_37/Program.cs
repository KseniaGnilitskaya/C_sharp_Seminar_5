/* Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предвоследний
и тд. Результат запишите в новом массиве.*/

int[] arr1 = {6, 7, 3, 6};

int[] arr2 = new int[arr1.Length / 2 + arr1.Length % 2];

for (int i = 0; i < arr2.Length; i++){
arr2[i] = arr1[i] * arr1[arr1.Length - 1 - i];
if (i == arr1.Length - 1 - i){
arr2[i] = arr1[i];
}
Console.Write($"{arr2[i]} ");
}
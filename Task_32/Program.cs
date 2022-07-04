/* Напишите программу замены элементов массива: положительные элементы
замените на соответствующие отрицательные, и наоборот */

int[] array = new int[10];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-20,21);
    Console.Write(array[i] + " ");
}
for (int i = 0, i < array.Length; i++){
    array[i] *= -1;
    Console.Write(array[i] + " ");
}
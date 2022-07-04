/* Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве */

int[] array = new int[5];

Console.WriteLine("Type the number: ");
for (int i = 0; i < array.Length; i++) {
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Type the number to find in array: ");
int number = int.Parse(Console.ReadLine());

//int flag = 0;
for (int i = 0, i < array.Length; i++) {
    if (array[i] == number) {
        //flag = 1;
        //break
        Console.Write("Yes");
        return;
    }
}
Console.Write("No");
/*if (flag == 0){
    Console.Write("No");
}
else {
    Console.Write("Yes");
}*/

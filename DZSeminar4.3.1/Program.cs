//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]



int[] myArray = new int[8];
Random rand = new Random();
Console.Write ("[");
for (int i = 0; i < myArray.Length; i++)
{
myArray[i] = rand.Next(99);
Console.Write( myArray [i] +(i < myArray.Length -1? "," : "") ) ;
}
Console.Write("]");

     


//Dzoi

//MANG 1 CHIEU
/*int sum = 0;
int[] a = { 1, 3, 5, 7, 9 };
for (int i = 0; i < a.Length; i++)
{
    sum += a[i];
    
}
Console.WriteLine(sum);*/
//////////////////

/*int[] nums = {10, 20, 30, 40,50 };
int sum = 0;
foreach (int num in nums)
{
    sum += num;
}
Console.WriteLine("Sum " + sum);*/
////////////////////

using System;
/*
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
int sum = 0;

//duyet
foreach (int num in nums)
{
    //kiem tra
    if (num % 2 == 0)
    {
        sum += num;
    }
}
Console.WriteLine("Sum is: " + sum);
*/
/////////////////

/*int[] numbers = { 4, 6, 3, 7, 8 };
Console.WriteLine(numbers[1]);
numbers[1] = 3000;
Console.WriteLine(numbers[1]);*/

//MANG 2 CHIEU
/*int sum = 0;
int[,] arr = { 
    { 1, 2, 3 },
    { 4, 5, 6 } 
};
for (int i = 0; i < arr.GetLength(0); i++) 
{ 
    for (int j = 0; j < arr.GetLength(1); j++) 
    {
        sum += arr[i,j];
    }
}
Console.WriteLine(sum);
*/
//MANG 3 CHIEU
/*int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 }, 
        { 4, 5, 6 } 
    },
    { 
        { 7, 8, 9 },
        { 10, 11, 12 } 
    }
}; 
Console.WriteLine(array3D[0, 0, 0]); 
Console.WriteLine(array3D[0, 1, 1]); 
Console.WriteLine(array3D[1, 1, 1]);*/
//Console.WriteLine(array3D[2, 0, 0])

/*List<byte[]> list = new List<byte[]>();
while (true)
{
    // allocate 1 GB of memory
    byte[] array = new byte[1024 * 1024 * 1024];
    list.Add(array);
}*/

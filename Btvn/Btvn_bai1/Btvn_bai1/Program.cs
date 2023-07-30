//ThiDN

using System.ComponentModel.DataAnnotations;

///MAX cua Mang mot chieu
///
/*Console.WriteLine("\n Nhap so phan tu cua mang: ");
int n =Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap phan tu thu: " + i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int max = arr[0];
for (int i = 0;i < n; i++)
{
    if (max < arr[i])
        max = arr[i];
}

Console.WriteLine("Max is: " +  max);*/

//MAX cua mang hai chieu

/*int[,] arr2D =
{
    {1,4,5,6,7,8, },
    {1,4,5,6,8,9 }
};
int max = arr2D[0, 0];

for (int i = 0; i < arr2D.GetLength(0); i++)
{
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        if (arr2D[i,j] > max)
        {
            max = arr2D[i,j];
        }
    }
}
Console.WriteLine(max);*/

//MAX cua mang ba chieu

int[,,] arr3D =
{
    {
        {2, 3 },
        { 4, 5 },
        { 6, 7 },
        { 8, 9 },
        { 9, 10 }
     }
};
int max = arr3D[0, 0, 0];
 for  (int i = 0; i < arr3D.GetLength(0); i++)
{
    for (int j = 0; j < arr3D.GetLength(1); j++)
    {
        for (int k = 0; k < arr3D.GetLength(2); k++)
        {
            if (arr3D[i, j, k] > max)
            {
                max = arr3D[i, j, k];
            }
        }
    }
}
Console.WriteLine(max);
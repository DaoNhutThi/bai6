//ThiDN

//MANG MOT CHIEU
/*int[] arr = { 2, 3, 4, 2, 5, 2, 6, 4, 7, 2 };

Console.WriteLine("\n Nhap so phan tu: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

foreach (int i in arr)
{
    if (i == n)
    {
        count++;
    }
}

Console.WriteLine(count);*/

//MANG HAI CHIEU
int[,] arr =
{
    {2, 3, 4, 2, 5},
    {2, 6, 4, 7, 2}
};

Console.WriteLine("\n Nhap so: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

foreach (int i in arr)
{
    if (i == n)
    {
        count++;
    }
}
Console.WriteLine(count);
//ThiDN

Console.Write("Nhap so phan tu: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Nhap phan tu: ");
    arr[i] = Convert.ToInt32(Console.ReadLine()) ;
}

int maxValue = arr[0];
int minValue = arr[1];

for (int i = 0; i < n; i++)
{
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
    if (arr[i] < minValue)
    {
        minValue = arr[i];
    }
}
Console.WriteLine("Max is: " + maxValue);
Console.WriteLine("Min is: "+ minValue);

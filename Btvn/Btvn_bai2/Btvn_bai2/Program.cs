//ThiDN

Console.WriteLine("\n Nhap so phan tu: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0, j = 0, tempt;
int[] arr = new int[n];

for (i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Nhap phan tu: ", i + 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
j = i - 1;
i = 0;

while( i < j)
{
    tempt = arr[i];
    arr[i] = arr[j];
    arr[j] = tempt;
    i++;
    j--;
}
Console.WriteLine("Mang da dao nguoc");
for  (i = 0; i < n; i++)
{
    Console.WriteLine(arr[i] + " ");
}
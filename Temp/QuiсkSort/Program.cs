// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = {7, 6, 3, 9, 8, 5, 1, 0, 2, 4};
int pivot = (n - 0) / 2;
Console.WriteLine($"Pivot = {pivot}, Элемент[pivot] = {a[pivot]}");
for(int y = 0; y < n; y++) 
    Console.Write($" {a[y]}");

int temp = 0;

Console.WriteLine();
Console.WriteLine();

int rec(int[] a, int n, int temp)
{
    int i = 0;
    int j = n - 1;


for(int i = 0; i < pivot; i++)
{
    for(int j = n - 1; j >= pivot; j--)
    {
        if(a[i] > a[pivot] && a[pivot] > a[j])
        {
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
    
}

}
for(int k = 0; k < n; k++)
                Console.Write($" {a[k]}");
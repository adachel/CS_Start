// На круглой грядке по окружности растет N кустов. 
// Таким образом, у каждого куста есть ровно два соседних. 
// Эти кусты обладают разной урожайностью, 
// поэтому ко времени сбора на них выросло различное число ягод 
// на i-ом кусте выросло ai ягод. Собирающий модуль за один заход, 
// находясь непосредственно перед некоторым кустом,
// собирает ягоды с этого куста и с двух соседних с ним. 
// Напиши программу для нахождения максимального числа ягод, 
// которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.

Console.Clear();
int[] arr = {4, 3, 2, 1}; // Урожай с кустов

int max = 0;
int b = arr[arr.Length -1] + arr[0] + arr[1];
int c = arr[arr.Length -2] + arr[arr.Length -1] + arr[0];

if (b > c) 
    max = b; 
else 
    max = c;

for (int i = 0; i < arr.Length - 2; i++)
{   
    int a = arr[i] + arr[i + 1] + arr[i + 2];

    if (a > max)
    max = a;
}

Console.WriteLine($"Максимальное число ягод: {max} ");


// Task dop
/*
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
 
int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];
 
if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];
 
Console.WriteLine(maxSumma);
*/

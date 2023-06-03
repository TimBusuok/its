// int[] array = new int[5];
// for(int i = 0; i < 5; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("[" + string.Join(",  ", array)+ "]");
// Console.WriteLine(array[3]);
// // сложность аллгоритма O(1)

// // сумма массива 
// // [4, 5, 3, 1, 2]
// // O(n)
// //[1, 2, 3, 4, 5] - O(n*logn)
// //((5 + 1)/2) * 5 - O(1)
// // n < n * log(n) + 
// int sum = 0;
// for(int i = 0;i < n; i++){
//     sum += array[i];
// }
// Console.WriteLine(sum);

int n = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int [n, n];
for(int i = 0; i < n; i++)
{
    for(int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
// O(n^2)

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int A = 0;
int Z = 0;
int K = 10;
int N = 1;
int D = 0;
Console.WriteLine("Введите число А:");
int.TryParse(Console.ReadLine()!, out A);
for (int i = 1; i < 10; i++)
{
    D = A%K/N;
    Z = Z+D;
    K = K*10;
    N = N*10;
}
Console.WriteLine($"Сумма равна {Z}");

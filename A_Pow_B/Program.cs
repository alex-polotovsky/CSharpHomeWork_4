/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());

int numPow = A;

if (B < 1)
{
    Console.WriteLine("Out of range.");
}

else
{
   for (int i = 2; i <= B; i++)
   {
        numPow = numPow * A;
   }
   Console.WriteLine("А в степени В равно: "+ numPow);
}








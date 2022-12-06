Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomnieChisla(numbers);
Console.WriteLine("массив: ");
Print(numbers);
int a = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
a++;

Console.WriteLine($"всего {numbers.Length}, {a} чётные");

void RandomnieChisla(int[] numbers)
{
    for(int i1 = 0; i1 < numbers.Length; i1++)
    {
        numbers[i1] = new Random().Next(100,1000);
    }
}
void Print(int[] numbers)
{
    
    for(int i2 = 0; i2 < numbers.Length; i2++)
    {
        Console.Write(numbers[i2] + " ");
    }
    
}








Console.WriteLine("Введите длину массива:  ");
int dlina = Convert.ToInt32(Console.ReadLine());
int[] chisla = new int[size];
Randomchisla1(chisla);
Console.WriteLine("массив: ");
Print1(chisla);

int b = 0;

for (int c = 0; c < chisla.Length; c+=2)
    b = b + chisla[c];

    Console.WriteLine($"всего {chisla.Length} чисел, сумма = {b}");

void Randomchisla1(int[] chisla)
{
    for(int i4 = 0; i4 < chisla.Length; i4++)
    {
        chisla[i4] = new Random().Next(100,1000);
    }
}
void Print1(int[] chisla)
{
    
    for(int i5 = 0; i5 < chisla.Length; i5++)
        {
            Console.Write(chisla[i5] + " ");
        }
    
    Console.WriteLine();
}
// факториал это 5!=5*4*3*2*1
//                  5*4!
//                    4*3!

// Задача: Функция принимает какое то число и показывает его факториал

double Factorial (int n)
{
    // 1!=1
    // 0!=1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

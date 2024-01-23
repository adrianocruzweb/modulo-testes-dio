using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 15;
int num2 = 22;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1,num2)}");
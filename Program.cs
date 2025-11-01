﻿int n = 0;
int maximo;
string seguir;
Console.Clear();
Console.WriteLine("------- Tabuada -------");
do
{
    Console.WriteLine("Digite o valor da tabuada ");
    maximo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Tabuada do {maximo}");
    while(n<=10)
    {
     int valor= maximo*n;
    Console.ForegroundColor = (ConsoleColor)(n%10);
    Console.Write($"{maximo}x{n}={valor} \n");
    Thread.Sleep(200);
    n=n+1;
    }
    n=0;
    Console.Write("Digite s para continuar ou n para sair: ");
    seguir=Console.ReadLine();

    while(seguir!="n" && seguir!="s")
    {
    Console.WriteLine("Digite s ou n!");
    seguir=Console.ReadLine();
    }

} 
while(seguir=="s");
Console.ResetColor();
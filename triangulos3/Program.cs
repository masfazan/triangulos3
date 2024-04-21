float lado1=0, lado2=0, lado3=0;

Console.WriteLine("Digite o comprimento dos três lados do triângulo: ");

Console.Write("Digite o lado 1: ");
lado1= float.Parse(Console.ReadLine());

Console.Write("Digite o lado 2: ");
lado2 = float.Parse(Console.ReadLine());

Console.Write("Digite o lado 3: ");
lado3 = float.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
    {
        Console.WriteLine("O triângulo é isósceles");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}
else
{
    Console.WriteLine("As medidas não são válidas.");
}
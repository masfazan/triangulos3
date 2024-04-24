float lado1=0, lado2=0, lado3=0;

Console.WriteLine("Digite o comprimento dos três lados do triângulo: ");

Console.Write("Digite o lado 1: ");
lado1= float.Parse(Console.ReadLine());

Console.Write("Digite o lado 2: ");
lado2 = float.Parse(Console.ReadLine());

Console.Write("Digite o lado 3: ");
lado3 = float.Parse(Console.ReadLine());

switch (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    case (lado1 == lado2 && lado2 == lado3):
     Console.WriteLine("O triângulo é equilátero");
        break;
    case (lado1 == lado2 || lado2 == lado3 || lado3 == lado1):
    Console.WriteLine("O triângulo é isósceles");
        break;
    default:
        Console.WriteLine("O triângulo é escaleno");
        break;
}
        Console.WriteLine("As medidas não são válidas.");
//LOCALIZAR ERRO
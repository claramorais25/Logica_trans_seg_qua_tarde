// Calcular que recebe 2 numero e apresenta + - * /


Console.WriteLine("Escreva o primeiro número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (numero1 + numero2));
Console.WriteLine("- : " + (numero1 - numero2));
Console.WriteLine("* : " + (numero1 * numero2));
 Console.WriteLine("/ : " + (numero1 / numero2));

// Verifica se o segundo númer é diferente de zero antes de reakizar a divisão

if (numero2 != 0)
{
    Console.WriteLine("/ : " + (numero1 / numero2));
}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA");
}

Console.WriteLine("============================");
Console.WriteLine("Os numero são iguais? " + (numero1 == numero2));
Console.WriteLine("Numero1 é maior numero 2? " + (numero1 > numero2));
Console.WriteLine("numero1 é menor numero 2? " + (numero1 < numero2));
Console.WriteLine("numero1 é maior igual numero 2? " + (numero1 >= numero2));
Console.WriteLine("numero1 é menor igual numero 2? " + (numero1 <= numero2));


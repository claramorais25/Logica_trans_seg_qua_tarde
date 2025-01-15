﻿
/* Objetivo: Criar um programa que verifique se uma pessoa pode entrar em um evento restrito com base na sua idade e se possui uma autorização.
 
Descrição:
 
- O programa deve solicitar ao usuário que digite sua idade.
- O programa deve perguntar se o usuário possui autorização para entrar no evento, aceitando as respostas "sim" ou "não".
- Com essas informações, o programa deve determinar se o usuário pode entrar no evento. A entrada é permitida se:
- O usuário for maior ou igual a 18 anos, ou
- O usuário possuir uma autorização.
- O programa deve informar ao usuário se ele pode ou não entrar no evento.
*/

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Voce possui autorização? (sim/não)");
string autorizacaoInput = Console.ReadLine().ToLower();
bool possuiAutorização = autorizacaoInput == "sim";

Console.Clear();

// Verifica se a pessoa pode entrar no evento

bool podeEntrar = (idade >= 18) || possuiAutorização;

if (podeEntrar)
{
    Console.WriteLine("Voce pode entrar no evento. ");
}
else
{
    Console.WriteLine("Voce NÃO pode entrar no evento. ");
}
Console.WriteLine("==========================");

Console.WriteLine("Voce é de maior de idade e tem autorização? " +
    (idade >= 18 && possuiAutorização));
Console.WriteLine("Voce não é maior de idade? " + (idade < 18));
Console.WriteLine("Voce é maior de idade ou tem autorização? " + (idade >= 18 ||
    possuiAutorização));
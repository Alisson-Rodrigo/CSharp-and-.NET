using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira seu nome
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        // Sauda o usuário
        Console.WriteLine($"Olá, {nome}! Bem-vindo ao mundo da programação em C#!");
    }
}

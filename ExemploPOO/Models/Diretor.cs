using System;
// Herança - sealed trava o comportamento de herança com a classe pai
namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }        
    }
}
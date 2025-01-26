using System;

namespace POO //name
{
    public class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new("Preto", "1300"); //! Coloquei cor e modelo
            Carro celta = new("Preto");

            //! Ao invé de acessarmoso atributo direto, acessamos a propriedade.
            fusca.Cor = "Branco";
            celta.Modelo = "Chevrolet";

            fusca.Acelerar();
            fusca.Acelerar();
            Console.WriteLine($"A velocidade é de {fusca.Velocimetro()} Km/h");
            fusca.Frear();
            fusca.Virar("direita");
            fusca.Acelerar();
            fusca.Frear();
            fusca.Virar("Esqeurda");
            fusca.Parar();

            Console.ReadKey();
        }
    }
}
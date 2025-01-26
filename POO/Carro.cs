namespace POO
{
    public class Carro //Teste
    {   //* ----- PROPRIEDADE ---- (Usado para modificar os items EMCAPSULADOS)
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        //        public string Cor{
        //! get = é um retorno, ele ta pegando um valor (nesse caso do atributo emcapsulado)
        //            get { return cor;}
        //! Set = vai receber no atributo um valor VALUE (significa que toda vez que eu definir um cor = alguma coisa ele vai pegar esse valor)
        //            set { cor = value;}
        //        }

        //! Criando Contrutor

        public Carro(string cor, string modelo)
        {
            Cor = cor;
            Modelo = modelo;
        }

        public Carro(string cor)
        {
            Cor = cor;
        }


        public void Acelerar()
        {
            Console.WriteLine("Carro Acelerando...");        //! Imprime que o carro ta acelerando
            Velocidade += 1;                                 //! Diz que minha velocidade vai receber +1 toda vez que acelerar      
        }

        public void Frear()
        {
            Console.WriteLine("Carro Freando...");
            Velocidade -= 1;
        }

        public int Velocimetro()
        {
            return Velocidade;                               //! Usada em metodos que eu necessite retortar um valor
        }

        public void Virar(string direcao)
        { //! Dessa vez coloquei um parâmetro, diz que vou ter q ter um valor em string que é direção
            Console.WriteLine($"Carro Virando Para a {direcao}");
        }

        public void Parar()
        {
            while (Velocidade > 0)
            {          //! Fiz um Loop (While), enquanto a velocidade > 0, tiro 1 ponto, até quando chegar a 0,
                       //! Ai sai do loop
                       //*velocidade -= 1; ou
                Frear();
            }
            Console.WriteLine("Carro Parado");
        }

    }
}
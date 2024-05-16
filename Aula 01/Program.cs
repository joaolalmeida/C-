namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {

            /* Int - -156 como 32334
               Float - -15,6 como 232.232
               Bool - true ou false
               String - "dasda dada"
               Char - 'a'
                                     */
            int segundaGuerraMundial = 1942;
            string cor_favorita = "Vermelho";
            float velocidadeF1 = 294.23f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);

            velocidadeF1 = 348.29f;

            Console.WriteLine(velocidadeF1);

            Console.WriteLine("Hello World!\n"); //Pular linha \n e tambem o WriteLine
            Console.WriteLine("Meu nome é Joao Almeida\n");

            Console.ReadLine();

        }
    }
}
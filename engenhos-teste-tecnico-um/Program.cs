using System;

namespace engenhos_teste_tecnico_um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            string inputDoUsuario = Console.ReadLine();

            //Transforma o input do usuário em um inteiro
            int inputDoUsuarioFormatado = short.Parse(inputDoUsuario);

            int resultadoFinal = SomaMultiplos(inputDoUsuarioFormatado);

            Console.WriteLine($"A soma dos multiplos de 3 e 5 abaixo de {inputDoUsuario}, é: {resultadoFinal}");
        }

        private static int SomaMultiplos(int inputDoUsuario)
        {
            int resultado = 0;
            int CONSTANTE_TRES = 3;
            int CONSTANTE_CINCO = 5;

            //O int estou iniciando com 1 porque somar 0 é mesma coisa de somar com nada
            for (int i = 1; i < inputDoUsuario; i++)
            {
                if (i % CONSTANTE_TRES == 0 || i % CONSTANTE_CINCO == 0)
                {
                    resultado += i;
                }
            }

            return resultado;
        }
    }
}

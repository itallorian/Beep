namespace Beep
{
    public class Funcoes
    {
        public int EscolherFrequencia()
        {
            int frequencia;

            Console.WriteLine("Escolha a frequência do Beep (hertz): ");
            string frequenciaInput = Console.ReadLine();

            if (Int32.TryParse(frequenciaInput, out frequencia) == false)
            {
                return 800;
            }

            return frequencia;
        }

        public int EscolherDuracao()
        {
            int duracao;

            Console.WriteLine("Escolha a duração do Beep (milisegundos): ");
            string duracaoInput = Console.ReadLine();

            if(Int32.TryParse(duracaoInput, out duracao) == false)
            {
                return 200;
            }

            return duracao;
        }

        public void ModoConstante(int frequencia, int duracao)
        {
            Console.WriteLine("Pressione CTRL + C para sair...");

            while (true)
            {
                Console.Beep(frequencia, duracao);
            }
        }

        public void ModoToque(int frequencia, int duracao)
        {
            Console.WriteLine("Pressione X ou CTRL + C para sair...");

            ConsoleKeyInfo informacaoTecla;

            do
            {
                informacaoTecla = Console.ReadKey();
                Console.Beep(frequencia, duracao);
            }
            while (informacaoTecla.Key != ConsoleKey.X);
        }
    }
}

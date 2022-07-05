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

        public void ModoTeclado()
        {
			Console.WriteLine("\nTeclas QWERTYUIOP possuem variação de 500 hertz!");
			Console.WriteLine("As demais teclas de caracteres possuem variações de 200 hertz!");
			Console.WriteLine("Pressione ESC ou CTRL + C para sair...\n");

			ConsoleKeyInfo keyinfo;
			string keyInput;

			do
			{
				keyinfo = Console.ReadKey();
				keyInput = keyinfo.KeyChar.ToString();
				switch (keyInput)
				{
					// Variações de 500 hertz
					// ===================
					case "q":
						Console.Beep(500, 100);
						break;
					case "w":
						Console.Beep(1000, 100);
						break;
					case "e":
						Console.Beep(1500, 100);
						break;
					case "r":
						Console.Beep(2000, 100);
						break;
					case "t":
						Console.Beep(2500, 100);
						break;
					case "y":
						Console.Beep(3000, 100);
						break;
					case "u":
						Console.Beep(3500, 100);
						break;
					case "i":
						Console.Beep(4000, 100);
						break;
					case "o":
						Console.Beep(4500, 100);
						break;
					case "p":
						Console.Beep(5000, 100);
						break;
					// Variações de 200 hertz (pulando as variações de 500)
					// ============================================
					case "a":
						Console.Beep(200, 100);
						break;
					case "s":
						Console.Beep(400, 100);
						break;
					case "d":
						Console.Beep(600, 100);
						break;
					case "f":
						Console.Beep(800, 100);
						break;
					case "g":
						Console.Beep(1200, 100);
						break;
					case "h":
						Console.Beep(1400, 100);
						break;
					case "j":
						Console.Beep(1600, 100);
						break;
					case "k":
						Console.Beep(1800, 100);
						break;
					case "l":
						Console.Beep(2200, 100);
						break;
					case "ç":
						Console.Beep(2400, 100);
						break;
					case "z":
						Console.Beep(2600, 100);
						break;
					case "x":
						Console.Beep(2800, 100);
						break;
					case "c":
						Console.Beep(3200, 100);
						break;
					case "v":
						Console.Beep(3400, 100);
						break;
					case "b":
						Console.Beep(3600, 100);
						break;
					case "n":
						Console.Beep(3800, 100);
						break;
					case "m":
						Console.Beep(4200, 100);
						break;
					// Qualquer outra tecla usa a frequência padrão
					// =====================================
					default:
						Console.Beep(800, 100);
						break;
				}
				Console.Write("\r");
			}
			while (keyinfo.Key != ConsoleKey.Escape);
		}
    }
}

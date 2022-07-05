using Beep;

string versao = "1.0";
string escolha;
int frequencia, duracao;
Funcoes funcao = new Funcoes();

Console.WriteLine("=======================================");
Console.WriteLine("Beep: O programa que bipa! - Versão " + versao);
Console.WriteLine("=======================================\n");

Console.WriteLine("Escolha o modo do programa:");
Console.WriteLine("---------------------------");
Console.WriteLine("(1) Modo Toque - Bipa quando tecla for pressionada");
Console.WriteLine("(2) Modo Constante - Bipa constantemente até o programa ser fechado\n");
Console.WriteLine("(3) Modo Teclado - Cada tecla bipa com diferentes frequências\n");

Console.Write("Escolha o modo (qualquer outra opção para sair): ");
escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        frequencia = funcao.EscolherFrequencia();
        duracao = funcao.EscolherDuracao();

        funcao.ModoToque(frequencia, duracao);
        break;
    case "2":
        frequencia = funcao.EscolherFrequencia();
        duracao = funcao.EscolherDuracao();

        funcao.ModoConstante(frequencia, duracao);
        break;
    case "3":
        funcao.ModoTeclado();
        break;
    default:
        Console.WriteLine("Saindo...");
        break;
}
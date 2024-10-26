//Exercícios do módulo 03

using System.Runtime.Serialization;

void Contas(double a, double b)
{
    double adicao = a + b;
    double subtracao = a - b;
    double multiplicacao = a * b;
    double divisao = a / b;
    double divisao2 = b / a;

    Console.WriteLine($"""
        Número a = {a}
        Número b = {b}

        Adição = {adicao}
        Subtração = {subtracao}
        Multiplicação = {multiplicacao}
        Divisão de {a} por {b} = {divisao}
        Divisão de {b} por {a} = {divisao2}
        """);
}

Contas(6, 3);

Console.WriteLine("\n*********************************************\n");

List<string> cantorasPrediletas = new List<string>();
cantorasPrediletas.Add("Mc Luanna");
cantorasPrediletas.Add("Duquesa");
cantorasPrediletas.Add("Liniker");

for(int i = 0; i < cantorasPrediletas.Count; i++)
{
    Console.Write("Cantora: ");
    Console.WriteLine(cantorasPrediletas[i]);
}

Console.WriteLine("\n*********************************************\n");

List<int> nums = new List<int> { 34, 67, 9, 9 };
int soma = 0;

foreach (int num in nums)
{
    soma += num;
}
Console.WriteLine(soma);

//------------------------------------------------------------------------------------------------------

//string mensagemDeBoasVindas = "Bem vinda a sua biblioteca de músicas online :)";
//List<string> bandas = new List<string>();

////Função
//void ExibirLogo()
//{
//    Console.WriteLine(@"
//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");    
//    Console.WriteLine($"\n{mensagemDeBoasVindas}");
//}

//void ExibirOpcoesDoMenu()
//{
//    Console.WriteLine("""

//        Menu
//        1 - Registrar banda
//        2 - Mostrar sua lista de bandas
//        3 - Avaliar uma banda
//        4 - Exibir a média de uma banda
//        0 - Para sair
//        """);

//    Console.Write("Digite sua opção: ");
//    //Ler a resposta e armazena
//    //! declara que o valor não pode ser nulo
//    string respostaMenu = Console.ReadLine()!;
//    int respostaMenuNum = int.Parse(respostaMenu);

//    switch(respostaMenuNum)
//    {
//        case 1: 
//            RegistrarBanda();
//            break;
//        case 2: 
//            MostrarBandas();
//            break;
//        case 3: 
//            //AvaliarBanda();
//            break;
//        case 4: 
//            //ExibirMediaBanda();
//            break;
//     }
//}

//void FinalFuncao()
//{
//    Thread.Sleep(2500);
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}
//void RegistrarBanda()
//{
//    Console.Clear();
//    Console.WriteLine("Registro de bandas");
//    Console.Write("Digite o nome da banda que você quer registrar: ");
//    string nomeBanda = Console.ReadLine()!;
//    bandas.Add(nomeBanda);
//    Console.WriteLine($"A banda {nomeBanda} foi registrado com sucesso!");
//    FinalFuncao();
//}

//void MostrarBandas()
//{
//    Console.Clear();
//    Console.WriteLine("Lista de bandas\n");
//    foreach (var banda in bandas)
//    {
//        Console.WriteLine(banda);
//    }
//    //Outra forma de imprimir(/correr) uma lista
//    //for (int i = 0; i < bandas.Count; i++) {
//    //Console.WriteLine(bandas[i]);
//    //}
//}

////Chamando função pra ser executada
//ExibirLogo();
//ExibirOpcoesDoMenu();

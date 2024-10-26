string mensagemDeBoasVindas = "Bem vinda a sua biblioteca de músicas online :)";
List<string> bandas = new List<string>() { "Racionais", "Los Hermanos", "Hypiranhas"};

//Função
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine($"\n{mensagemDeBoasVindas}");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("""

        Menu
        1 - Registrar banda
        2 - Mostrar sua lista de bandas
        3 - Avaliar uma banda
        4 - Exibir a média de uma banda
        0 - Para sair
        """);

    Console.Write("Digite sua opção: ");
    //Ler a resposta e armazena
    //! declara que o valor não pode ser nulo
    string respostaMenu = Console.ReadLine()!;
    int respostaMenuNum = int.Parse(respostaMenu);

    switch (respostaMenuNum)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            //AvaliarBanda();
            break;
        case 4:
            //ExibirMediaBanda();
            break;
    }
}

void FinalFuncao()
{
    Thread.Sleep(2500);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que você quer registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrado com sucesso!");
    FinalFuncao();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Lista de bandas");
    foreach (var banda in bandas)
    {
        Console.WriteLine($"- {banda}");
    }
    //Outra forma de imprimir(/correr) uma lista
    //for (int i = 0; i < bandas.Count; i++) {
    //Console.WriteLine(bandas[i]);
    //}
    FinalFuncao();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeDeLetrasTitulo = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetrasTitulo, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

//Chamando função pra ser executada
ExibirLogo();
ExibirOpcoesDoMenu();

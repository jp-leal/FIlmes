using System.Security.Cryptography.X509Certificates;

var filmes = new List<string>();

while(true) {
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1- Cadastrar Filme");    
    Console.WriteLine("2- Listar Filmes");
    Console.WriteLine("3- Remover Filme");
    Console.WriteLine("0- Sair");

var opcao = Console.ReadLine();

switch(opcao) {
    case "1":
    Console.WriteLine("Digite o nome do filme.");
    var nomeFilme = Console.ReadLine();
    filmes.Add(nomeFilme);
    Console.WriteLine("Filme cadastrado com sucesso.");
    break;
    case "2":
    foreach(var filme in filmes) {
        Console.WriteLine(filme);
    }
    break;
    case "3":
    Console.WriteLine("Digite o nome do filme.");
    var filmeRemover = Console.ReadLine();
    var sucesso = filmes.Remove(filmeRemover); 
    if(sucesso) {
        Console.WriteLine("Filme removido com sucesso.");
    } else {
        Console.WriteLine("Filme nao encontrado.");
    }
    break;
    case "4":
    break;
    case "0":
    Console.WriteLine("Encerrando a aplicacao");
    break;
    default:
    Console.WriteLine("Opcao invalida");
    break;
}
}


Console.WriteLine("Hello, World!");

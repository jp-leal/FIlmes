using System.Security.Cryptography.X509Certificates;

var filmes = new List<Filme>();

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
Console.WriteLine("Digita a nota do filme (0-10):");
var nota = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o genero do filme.");
    var genero = Console.ReadLine();
        Console.WriteLine("Digite o pais do filme.");
    var pais = Console.ReadLine();
        Console.WriteLine("Digite o idioma do filme.");
    var idioma = Console.ReadLine();
        Console.WriteLine("Digite o ano do filme.");
    var ano = Convert.ToInt32(Console.ReadLine());
    filmes.Add(new Filme(nomeFilme, nota, genero, idioma, pais, ano));
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
   var filmeEncontrado = filmes.Find(filme => filme.nome == filmeRemover);
   if (filmeEncontrado != null)
  {
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


class Filme {
    public string nome {get; }
    public double nota {get; }
    public string genero {get; }
    public string idioma {get; }
    public string pais {get; }
    public int ano {get; }

    public Filme (string nome, double nota, string genero, string idioma, string pais, int ano) {
        this.nome = nome;
        this.nota = nota;
        this.genero = genero;
        this.idioma = idioma;
        this.pais = pais;
        this.ano = ano;
    }

    public override string ToString()
    {
        return $"{nome} - Nota: {nota}, Gênero: {genero}, País: {pais}, Idioma: {idioma}, Ano de Lançamento: {ano}";
    }
}

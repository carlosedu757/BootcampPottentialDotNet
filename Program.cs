using ExemploExplorando.Models;
using System.Data.Common;
using System.Globalization;
using Newtonsoft.Json;

/*
bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}*/







string conteudoArquivo = File.ReadAllText("../../../Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, " +
                      $"Data da venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, "+
                      $"Desconto: {(venda.Desconto.HasValue ? venda.Desconto : "Sem desconto")}");
}

Console.ReadLine();

/*
DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("../../../Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);
*/
/*
int numero = 2103;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"{numero} é " + (ehPar ? "par" : "ímpar"));
                                    // IF TERNÁRIO ↑↑↑
*/


/*
Pessoa p1 = new Pessoa("Leonardo", "Vtl");
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
*/

/*
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linesFile, _) = arquivo.LerArquivo("../../../Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantityLines}");
    foreach(string line in linesFile)
    {
        Console.WriteLine(line);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
*/


/*
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Carlos", "Eduardo", 10.5M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Carlos", "Eduardo", 10.5M);
var outroExemploTuplaCreate = Tuple.Create(1, "Carlos", "Eduardo", 10.5M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");]
*/


/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]);

foreach(var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - Valor Alterado";

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe, é segura adicionar {chave}");
}
*/


/*
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);
foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/


/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
*/



// new ExemploExcecao().Metodo1();


/*
try
{
    string[] linhas = File.ReadAllLines("../../../Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Chegou até aqui, aperte qualquer botão para continuar...");
    Console.ReadLine();
}
*/

// string dataString = "2022-13-17 18:34";

// bool success = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if(success)
//     Console.WriteLine(data);
// else
//     Console.WriteLine("Data inválida.");




// decimal valorMonetario = 182.40M;

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .2413;

// Console.WriteLine(porcentagem.ToString("P"));



// Pessoa p1 = new Pessoa("Carlos", "Pita");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Rodrigues");

// Curso curso = new Curso();
// curso.Nome = "Science Computation";
// curso.Alunos = new List<Pessoa>();

// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();


// p1.Nome = "Carlos";
// p1.Sobrenome = "Pita";
// p1.Idade = 1;
// p1.Apresentar();
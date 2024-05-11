
using Newtonsoft.Json;
using Curso_Net_2;
using System.Globalization;
using Curso_Net_2.Models;

//***************************************************************************
//Deserialize

string jsonFile = File.ReadAllText("Arquivos/vendasDeserialize.json");

List<VendaDeserialize> listDeVendas = JsonConvert.DeserializeObject<List<VendaDeserialize>>(jsonFile);

foreach (VendaDeserialize venda in listDeVendas)
{
    Console.WriteLine($"Venda:\n Id: {venda.Id} Product: {venda.ProductName} preço: {venda.Preco} hora da venda: {venda.dataDeVenda.ToString("dd/MM/yyy HH:mm")}");
}

// //***************************************************************************
// //serialization json Venda exemplo:

// DateTime dataDeVenda = DateTime.Now;
// List<Venda> listaDevendas = new List<Venda>();
// Venda v1 = new Venda(1, "Material de escritorio", 20.99M, dataDeVenda);
// Venda v2 = new Venda(2, "Material de oficina", 240.99M, dataDeVenda);

// listaDevendas.Add(v1);
// listaDevendas.Add(v2);

// string jsonSerialized = JsonConvert.SerializeObject(listaDevendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", jsonSerialized);

// Console.WriteLine($"json Serialized: {jsonSerialized}");




//***************************************************************************
//Exemplo descontructor:
// //chamando contrusctor, isto esta construindo "Alejandro", "Garcia"
// Pessoa p1 = new Pessoa("Alejandro", "Garcia");

// //chamando descontructor, isto esta discontruindo "Alejandro", "Garcia" de p1 en variaveis  para variaveis string nome, string sobrenome
// (string nome, string sobrenome) = p1;

// //imprimiendo variaveis descontruidas
// Console.WriteLine($"{nome} {sobrenome}");


//***************************************************************************
//exemplo: if ternario
// int numero = 10;
// bool esPar = false;

// //if ternario
// esPar = numero % 2 == 0;
// Console.WriteLine($"O nnúmero {numero} é " + (esPar ? "par" : "impar"));

// //***************************************************************************
// //PARA DESCARTAR  USO DE UMA VARIAVEL PODE COLOCAR _
// //EXEMPLO: var (sucess, lines, total_Lines) = arquivo.readFile("Arquivos/arquivoLeitura.txt");
// // SE NAO QUER USAR MAIS A "total_Lines" REMPLAZA POR "_"
// ////EXEMPLO: var (sucess, lines, _) = arquivo.readFile("Arquivos/arquivoLeitura.txt");
// //Tuple, read file
// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucess, lines, _ ) = arquivo.readFile("Arquivos/arquivoLeitura.txt");

// if(sucess)
// {
//     foreach (var line in lines)
//     {
//         int lineNumber = Array.IndexOf(lines, line )+1;
//         Console.WriteLine($"Linha {lineNumber} {line}");
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }

//***************************************************************************
//Tuple, declarando variavel
// (int id, string Nome, string Sobre, decimal Altura) tupla = (1, "Alejandro", "Garcia", 1.83M);
// //otra forma para declarar tuple, no se podra declrar nombre de variables
// ValueTuple<int, string, string, decimal> outroExemploDeTupla = (2, "Ejemplo 2 de tuplas", "Garcia", 1.83M);
// //Otra forma mas de declarar, no se podra declrar nombre de variables
// var outroExemploDeTuplaCreate = Tuple.Create(1, "Alejandro", "Garcia", 1.83M);

// //imprimiendo por item de tuple
// Console.WriteLine($"{tupla}");
// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// Console.WriteLine($"\n**********************************************");

// //imprimiendo por nombre de variavel dentro de tuple:
// Console.WriteLine($"Id: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobre}");
// Console.WriteLine($"Altura: {tupla.Altura}");



//***************************************************************************
//Dictionary A Chave sempre deve ser unica
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("CR", "Curitiba");
// estados.Add("MG", "Minas Gerais");

// //Dictionary A Chave sempre deve ser unica
// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Value: {item.Value}");
// }
// Console.WriteLine($"\n**********************************************");

// estados.Remove("CR");

// //mudando valor da chave
// estados["SP"] = "São Paulo alterado";
// //Dictionary A Chave sempre deve ser unica
// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Value:{item.Value}");
// }


//validando se uma chave ja existe
// Console.WriteLine($"\n**********************************************");

// string chave = "BA";
// Console.WriteLine($"validando se a chave: {chave} ja existe");


// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"A chave: {chave} ja existe");
// }
// else
// {
//     Console.WriteLine($"A chave: {chave} não existe");
// }
//tambem pode ser:
// foreach(var item in estados)
// {
//      Console.WriteLine($"Chave: {item.Key}, Value:{item.Value}");
// }

//***************************************************************************
//*LIFO (LAST IN FIRST OUT)
// Stack<int> pilha = new Stack<int>();

// pilha.Push(9);
// pilha.Push(3);
// pilha.Push(4);



// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"\n**********************************************");
// //Pop remueve o elemento no topo da pilha
// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// pilha.Push(30);
// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }


//***************************************************************************
//FILA FIFO (FIRST IN FIRST OUT)
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);
// fila.Enqueue(7);


// foreach (var item in fila)
// {
//     Console.Write(item);
// }

// Console.WriteLine($"\n**********************************************");
//Dequeue remueve de la fila al primer elemento
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(3);
// foreach (var item in fila)
// {
//     Console.Write(item);
// }

//***************************************************************************
//Exception
//new ExemploExcecao().Metodo1();

//***************************************************************************
// try
// {
//     //ler arquivo
//     string [] linhas = File.ReadAllLines ("Arquivos/arquivoLeitura.txt");
//     foreach (string linha in linhas) 
//     {
//         int numeroDeLinha = Array.IndexOf (linhas, linha) +1;
//         Console.WriteLine($"Linha numero {numeroDeLinha}: -{linha}");
//     }
// }
// catch (FileNotFoundException ex) 
// {
//     Console.WriteLine($"Occureu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex) 
// {
//     Console.WriteLine($"Occureu uma erro. Diretorio não encontrado: {ex.Message}");
// }
// catch (Exception ex) 
// {
//     Console.WriteLine($"Occureu uma exeção genérica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine ("Chegou ate aqui");
// }


//***************************************************************************

// string dataString = "2022-04-17 18:00";

// //tryParseExac retorua un bool y cria uma nova variavel
// bool dataValidada = DateTime.TryParseExact(dataString, 
// "yyyy-MM-dd HH:mm", 
// CultureInfo.InvariantCulture, 
// DateTimeStyles.None, 
// out DateTime data2);



// if(dataValidada)
// {
//     Console.WriteLine($"Conversão com successo! Data: {data2}");
// }
// else
// {
// Console.WriteLine($"{dataString} não é uma data valida: ");
// }


// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());




//***************************************************************************
// decimal valorMonetario = 82.40M;

// Console.WriteLine($"valorMonetario Moeda do sistema: {valorMonetario:C2}");

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// double numero = 11956879896;

// Console.WriteLine(numero.ToString("+56-##-###-###-###"));

//***************************************************************************



//**************************************************************
// string valorMonetarioEUR = valorMonetario.ToString("C2", CultureInfo.GetCultureInfo("es-ES"));
// string valorMonetarioFR = valorMonetario.ToString("C2", CultureInfo.GetCultureInfo("zh-CN"));

// Console.WriteLine($"valorMonetario Moeda EUR: {valorMonetarioEUR}");
// Console.WriteLine($"valorMonetario Moeda FR: {valorMonetarioFR}");


//********************************************************
// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 +  numero2;

// Console.WriteLine(resultado);

//********************************************************
//chamando o contrusctor:
// Pessoa p1 = new Pessoa(nome: "Alejandro", sobrenome: "Garcia");
// Pessoa p2 = new Pessoa(nome: "Letzalet", sobrenome:"Amoroso");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

//********************************************************


// p1.Nome = "Alejandro";
// p1.Sobrenome = "Garcia";
// p1.Idade = 20;
// p1.Apresentar();


using System.Collections;

Hashtable openWith = new Hashtable();

openWith.Add("txt","notepad.exe");
openWith.Add("bmp","paint.exe");
openWith.Add("dib","paint.exe");
openWith.Add("rtf","wordpad.exe");

try
{
   openWith.Add("txt","notepad++.exe");
}
/*
catch(ArgumentException aex)
{
    Console.WriteLine("Oops, deu erro cabaço");
    Console.WriteLine($"Detalhes:{aex.Message}");
}
*/
catch(Exception ex)
{
    Console.WriteLine("Erro RONALDO.");
}
// Acessando a tabela hash

Console.WriteLine("Na \\ chave = \"rtf\"  {0}",openWith["rtf"]);

//Testar se a chave existe no hash
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht","hypertrm.exe");
    Console.WriteLine("Chave ht adicionada");
}

// Percorrendo hash com foreach

Console.WriteLine();
foreach(DictionaryEntry de in openWith)
{
    Console.WriteLine("Key = {0} - value = {1}", de.Key, de.Value);
}
// Obtendo apenas os valores do hash

ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("Value = {0}", s);
}

// Obtendo apenas as chaves do hash
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}

// Removendo registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Chave \"doc\" foi removida");
}





Console.WriteLine ("Programa ainda esta em execução");

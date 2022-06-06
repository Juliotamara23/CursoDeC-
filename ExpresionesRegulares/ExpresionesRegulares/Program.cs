// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string txt = "curso@pildorasinformaticas.es";

string re1 = ",*?";
string re2 = "@";
string re3 = ".*?";
string re4 = "\\.";


Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
Match match = r.Match(txt);

if (match.Success)
{
    Console.WriteLine("Se han encontrado la pagina");
}
else
{
    Console.WriteLine("No se han encontrado la pagina ");
}
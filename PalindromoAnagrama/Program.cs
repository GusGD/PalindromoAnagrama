using System.Text.RegularExpressions;

string frasePalindromo, fraseInverso, frase, novaFrasePalindromo;
int i;

fraseInverso = "";

Console.WriteLine("Digite uma frase ou uma palavra: ");
frasePalindromo = Convert.ToString(Console.ReadLine());
//tratamento para retirar o espaço da frase digitada
novaFrasePalindromo = Regex.Replace(frasePalindromo, @"\s", "").ToUpper();

i = novaFrasePalindromo.Length;

//Pegando a palavra de trás pra frente
for (int x = i - 1; x >= 0; x--)
{
    frase = novaFrasePalindromo.Substring(x, 1);
    fraseInverso = fraseInverso + frase;
}

//utilizei tabela da verdade para definir true ou false
if (novaFrasePalindromo == fraseInverso && Anagrama())
{
    Console.WriteLine(true + " " + frasePalindromo + " é um palíndromo e um anagrama");
}else if (novaFrasePalindromo == fraseInverso && Anagrama())
{
    Console.WriteLine(false + " " + frasePalindromo + " é um palíndromo mas não é um anagrama");
}
else if (novaFrasePalindromo != fraseInverso && Anagrama())
{
    Console.WriteLine(false + " " + frasePalindromo + " não é um palíndromo mas é um anagrama");
}
else
{
    Console.WriteLine(false + " " + frasePalindromo + " não é um palíndromo e nem um anagrama");
}

bool Anagrama()
{
    if (Alpha(novaFrasePalindromo) == Alpha(fraseInverso))
    {
        return true;
    }
    else
    {
        return false;
    }
}
static string Alpha(string str)
{
    char[] arr = str.ToCharArray();
    Array.Sort(arr);
    return new string(arr);
}

Console.ReadKey();
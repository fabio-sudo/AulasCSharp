/* IF idade
int idade;
Console.WriteLine("Informe sua idade!");

idade = Convert.ToInt32(
    Console.ReadLine());


if (idade >= 18)
{
    Console.WriteLine($"Sua idade {idade}, você é maior de idade");
}
else
{
    Console.WriteLine($"Sua idade {idade}, você é menor de idade");
}*/


/*Exemplo Salário IF
const decimal salarioMinimo = 1518m;

Console.Write("Digite o salário do funcionário: R$ ");
decimal salarioFuncionario = decimal.Parse(Console.ReadLine());

if (salarioFuncionario == salarioMinimo)
{
    Console.WriteLine($"O funcionário recebe o salário mínimo. {salarioFuncionario:C}");
}
else
{
    Console.WriteLine($"O funcionário NÃO recebe o salário mínimo.{salarioFuncionario:C}");
}
*/


float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;

Console.WriteLine("Informe a operação matemática:\n" +
    "+ ou - ou * ou /");

operacaoMatematica = Console.ReadLine();

Console.WriteLine("Informe o primeiro valor");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor");
num2 = float.Parse(Console.ReadLine());


if (operacaoMatematica == "+")
{
    Console.WriteLine($"Soma:{(num1 + num2):F2}");
}
else if (operacaoMatematica == "-")
{
    Console.WriteLine($"Subtração:{num1 - num2}");
}
else if (operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicação:{num1 * num2}");
}
else if (operacaoMatematica == "/")
{
    Console.WriteLine($"Divisão:{num1 / num2}");
}
else { Console.WriteLine("Operação inválida"); }
using calculoSalarioLiquido;

double salario, aliquota, salLiq;

Console.WriteLine ("Digite o salário do funcionario:");
salario = Convert.ToDouble(Console.ReadLine());
salLiq = 0;

Funcionario Varfuncionario = new Funcionario();
Varfuncionario.Nome = "Caio";

List<Funcionario> Funcionarios = new List<Funcionario>();
Funcionarios.Add(funcionario);
Console.WriteLine(Varfuncionario.Nome);
if (salario <= 1903.38)
{
    salLiq = salario;
}
if (salario >= 1903.39 && salario <= 2826.65)
{
    aliquota = 0.925;
    salLiq = (salario * aliquota) - 142.80;
}
if (salario >= 2826.66 && salario <= 3751.06)
{
    aliquota = 0.85;
    salLiq = (salario * aliquota) - 354.80;
}
if (salario >= 3751.07 && salario <= 4664.68)
{
    aliquota = 0.775;
    salLiq = (salario * aliquota) - 636.13;
}
if (salario >= 4664.69)
{
    aliquota = 0.725;
    salLiq = (salario * aliquota) - 869.36;
}
Console.WriteLine($"Salário liquido de: {Math.Round(salLiq, 2)}");
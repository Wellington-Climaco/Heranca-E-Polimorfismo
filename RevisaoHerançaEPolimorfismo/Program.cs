using RevisaoHerançaEPolimorfismo.Entidades;
using System.Globalization;

Console.Write("Entre com o numero de funcionarios: ");
int QtdFuncionarios = int.Parse(Console.ReadLine());
List<Funcionario> funcionarios = new List<Funcionario>();

for (int i = 0; i < QtdFuncionarios; i++)
{
    Console.WriteLine($"Dados Funcionario {i+1} ");
    Console.Write("Terceirado? (S/N): ");
    string IdentificacaoFuncionario = Console.ReadLine().ToUpper();

    Console.Write("Nome: ");
    string Nome = Console.ReadLine();
    Console.Write("Horas trabalhadas: ");
    int HorasTrabalhadas = int.Parse(Console.ReadLine());
    Console.Write("Valor Por Hora: ");
    double ValorPorHora = double.Parse(Console.ReadLine());

    if (IdentificacaoFuncionario == "S")
    {
        Console.Write("Despesa Adicional: ");
        double Despesa = double.Parse(Console.ReadLine());
        funcionarios.Add(new FuncionarioTercerizado(Nome, HorasTrabalhadas, ValorPorHora, Despesa));
        
    }
    else
    {
        funcionarios.Add(new Funcionario(Nome, HorasTrabalhadas, ValorPorHora));
    }
}

Console.WriteLine("Pagamentos: ");
foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} - {funcionario.PagamentoSalario().ToString("F2",CultureInfo.InvariantCulture)} "); 

}

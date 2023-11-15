using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoHerançaEPolimorfismo.Entidades
{
    internal class Funcionario
    {
        public string Nome {  get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }
        public FuncionarioTercerizado funcionarioTercerizado { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string name, int horasTrabalhadas, double valorhora)
        {
            Nome = name;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorhora;
            
        }

        public virtual double PagamentoSalario()
        {
            return ValorPorHora * HorasTrabalhadas;
        }


    }
}

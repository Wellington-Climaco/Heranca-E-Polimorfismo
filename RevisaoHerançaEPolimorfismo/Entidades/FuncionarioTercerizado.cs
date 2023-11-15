using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoHerançaEPolimorfismo.Entidades
{
    internal class FuncionarioTercerizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTercerizado(string name, int horasTrabalhadas, double valorhora,double despesaAdicional) : base(name, horasTrabalhadas, valorhora)
        {
            Nome = name;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorhora;
            DespesaAdicional = despesaAdicional;
        }

        public override double PagamentoSalario()
        {
             double porcentagem = DespesaAdicional * 0.1;
            return (ValorPorHora * HorasTrabalhadas) + porcentagem + DespesaAdicional;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoSalarioLiquido
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int Rg  { get; set; }
        public int Cpf { get; set; }
        public string Estado { get; set; }
        public float Salario { get; set; }
    }
}

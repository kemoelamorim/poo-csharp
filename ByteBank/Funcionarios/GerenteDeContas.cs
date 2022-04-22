using ByteBank.Sistama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf): base(nome, cpf, 4000)
        {

        }
        public override double GetBonilicacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}

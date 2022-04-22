﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string nome, string cpf): base(nome, cpf, 3000)
        {

        }
        public override double GetBonilicacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}

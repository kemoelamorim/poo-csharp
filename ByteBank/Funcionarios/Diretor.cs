﻿using ByteBank.Sistama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf): base(nome, cpf, 5000)
        {
        }
       
        public override double GetBonilicacao()
        {
            return Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        
    }
}

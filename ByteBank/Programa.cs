using ByteBank.Funcionarios;
using ByteBank.Sistama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            //CalcularBolificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            Diretor roberta = new Diretor("Roberta", "222.222.222-22");
            roberta.Senha = "123";
            GerenteDeContas camila = new GerenteDeContas("Camila", "333.333.333-33");
            camila.Senha = "321";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "abc";

            SistemaInterno sistemaInterno = new SistemaInterno();
            
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "321");
            sistemaInterno.Logar(parceiroComercial, "abc");
        }

        public static void CalcularBolificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Auxiliar igor = new Auxiliar("Igor", "000.000.000-00");

            Designer pedro = new Designer("Pedro", "111.111.111-11");

            Diretor roberta = new Diretor("Roberta", "222.222.222-22");

            GerenteDeContas camila = new GerenteDeContas("Camila", "333.333.333-33");

            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(camila);
        }
    }
}

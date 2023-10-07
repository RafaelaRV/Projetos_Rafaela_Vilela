using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionário.Modelo
{
    {
        public class Controle
        {
            public string mensagem;

            public void adicionarFuncionario(List<String> listaDadosFuncionario)
            {
                Validacao validacao = new Validacao();
                validacao.validarDadosFuncionario(listaDadosFuncionario);
                if (validacao.mensagem.Equals(""))
                {
                   Funcionario funcionario = new Funcionario();
                    funcionario.nome = listaDadosPessoa[0];
                    funcionario.rg = listaDadosPessoa[1];
                    funcionario.cpf = listaDadosPessoa[2];
                    FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                    funcionarioDAO.adicionarfuncionario(funcionario);
                    this.mensagem = funcionarioDAO.mensagem;
                }
                else
                {
                    this.mensagem = validacao.mensagem;
                }

            }
        }
    }
}

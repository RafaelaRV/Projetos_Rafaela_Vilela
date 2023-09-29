using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas_1._0.Modelo
{
    public class Controle
    {
        public String mensagem;

        public void cadastrarPessoa(List<String> listaDadosPessoa)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosPessoa(listaDadosPessoa);
            if (validacao.mensagem.Equals(" "))
            {


            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}

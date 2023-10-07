using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionário.Modelo
{
    public class Validação
    {
        public String mensagem;
        public int id;

        public void validaridFuncionario(String idFuncionario)
        {
            this.mensagem = "";
            try
            {
                id = Convert.ToInt32(idFuncionario);
            }
            catch (Exception e)
            {
                this.mensagem = "ID inválido";
            }
        }

        public void
     
      
        }
    public String mensagem;

    public void validarDadosFuncionario(List<String> listaDadosFuncionario)
    {
        this.mensagem = "";
        if (listaDadosFuncionario[0].Length < 3)
            this.mensagem += "Nome deve ter mais que 3 caracteres\n";
        if (listaDadosFuncionario[0].Length > 50)
            this.mensagem += "Nome deve ter menos que 50 caracteres\n";
        if (listaDadosFuncionario[1].Length > 10)
            this.mensagem += "RG deve ter menos que 10 caracteres\n";
        if (listaDadosFuncionario[2].Length > 13)
            this.mensagem += "CPF deve ter menos que 13 caracteres\n";
        if(listaDadosFuncionario[0].Length < 10)
            this.mensagem += "Endereço deve ter mais que 10 caracteres\n";
        if(listaDadosFuncionario[0].Length < 3)
            this.mensagem += "E-mail deve ter mais que 3 caracteres\n";
        if(listaDadosFuncionario[0].Length < 3)
            this.mensagem += "Telefone deve ter mais que 3 caracteres\n";
    }
}
}


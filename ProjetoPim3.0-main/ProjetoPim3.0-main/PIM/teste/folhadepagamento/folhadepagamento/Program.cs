using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular Folha de Pagamento");

        // Solicitar informa��es do funcion�rio
        Console.Write("Nome do funcion�rio: ");
        string nome = Console.ReadLine();

        Console.Write("Id do funcion�rio: ");
        string idFuncionario = Console.ReadLine();

        Console.Write("Nome do cargo do funcion�rio: ");
        string nomeCargo = Console.ReadLine();

        Console.Write("Dias trabalhados: ");
        double diasTrabalhados = Convert.ToDouble(Console.ReadLine());

        Console.Write("Sal�rio por dia: ");
        double salarioDia = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = diasTrabalhados * salarioDia;

        // Solicitar desconto do INSS
        Console.Write("Desconto do INSS (%): ");
        double descontoINSS = Convert.ToDouble(Console.ReadLine());

        if (salarioBruto < 1300)
        {
            descontoINSS = salarioBruto * 0.075; // 7,5%
        }
        else if (salarioBruto > 1300 && salarioBruto <= 2571.29)
        {
            descontoINSS = salarioBruto * 0.09; // 9%
        }
        else if (salarioBruto > 2571.29 && salarioBruto <= 3856.94)
        {
            descontoINSS = salarioBruto * 0.12; // 12%
        }
        else if (salarioBruto > 3856.94 && salarioBruto <= 7507.49)
        {
            descontoINSS = salarioBruto * 0.14; // 14%
        }
        else
        {
            Console.WriteLine("Este funcion�rio n�o possui desconto de INSS");
            return;
        }

        // Calcular sal�rio l�quido ap�s desconto do INSS
        double salarioLiquido = salarioBruto - descontoINSS;

        // Solicitar desconto do Imposto de Renda
        Console.Write("Desconto do Imposto de Renda: ");
        double descontoIR = 0.0;

        if (salarioBruto <= 2184.00)
        {
            Console.WriteLine("Este funcion�rio n�o possui desconto de Imposto de Renda");
        }
        else if (salarioBruto <= 2552.00)
        {
            descontoIR = salarioBruto * 0.075; // 7,5%
        }
        else if (salarioBruto <= 2609.20)
        {
            descontoIR = salarioBruto * 0.15; // 15%
        }
        else if (salarioBruto <= 4204.54)
        {
            descontoIR = salarioBruto * 0.225; // 22,5%
        }
        else
        {
            descontoIR = salarioBruto * 0.275; // 27,5%
        }

        // Calcular sal�rio l�quido ap�s desconto do Imposto de Renda
        salarioLiquido -= descontoIR;

        Console.WriteLine("\nResumo da Folha de Pagamento:");
        Console.WriteLine("Nome do funcion�rio: " + nome);
        Console.WriteLine("Id do Funcion�rio: " + idFuncionario);
        Console.WriteLine("Sal�rio Bruto: " + salarioBruto.ToString("C"));
        Console.WriteLine("Desconto do INSS: " + descontoINSS.ToString("C"));
        Console.WriteLine("Desconto do Imposto de Renda: " + descontoIR.ToString("C"));
        Console.WriteLine("Sal�rio L�quido: " + salarioLiquido.ToString("C"));

        Console.ReadLine(); // Aguardar at� que o usu�rio pressione Enter
    }
}
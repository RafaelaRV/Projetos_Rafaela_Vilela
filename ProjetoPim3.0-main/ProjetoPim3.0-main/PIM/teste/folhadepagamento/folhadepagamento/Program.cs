using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular Folha de Pagamento");

        // Solicitar informações do funcionário
        Console.Write("Nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Id do funcionário: ");
        string idFuncionario = Console.ReadLine();

        Console.Write("Nome do cargo do funcionário: ");
        string nomeCargo = Console.ReadLine();

        Console.Write("Dias trabalhados: ");
        double diasTrabalhados = Convert.ToDouble(Console.ReadLine());

        Console.Write("Salário por dia: ");
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
            Console.WriteLine("Este funcionário não possui desconto de INSS");
            return;
        }

        // Calcular salário líquido após desconto do INSS
        double salarioLiquido = salarioBruto - descontoINSS;

        // Solicitar desconto do Imposto de Renda
        Console.Write("Desconto do Imposto de Renda: ");
        double descontoIR = 0.0;

        if (salarioBruto <= 2184.00)
        {
            Console.WriteLine("Este funcionário não possui desconto de Imposto de Renda");
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

        // Calcular salário líquido após desconto do Imposto de Renda
        salarioLiquido -= descontoIR;

        Console.WriteLine("\nResumo da Folha de Pagamento:");
        Console.WriteLine("Nome do funcionário: " + nome);
        Console.WriteLine("Id do Funcionário: " + idFuncionario);
        Console.WriteLine("Salário Bruto: " + salarioBruto.ToString("C"));
        Console.WriteLine("Desconto do INSS: " + descontoINSS.ToString("C"));
        Console.WriteLine("Desconto do Imposto de Renda: " + descontoIR.ToString("C"));
        Console.WriteLine("Salário Líquido: " + salarioLiquido.ToString("C"));

        Console.ReadLine(); // Aguardar até que o usuário pressione Enter
    }
}
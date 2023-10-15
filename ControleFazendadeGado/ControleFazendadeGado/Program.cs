using System;

class Program
{
    struct Gado
    {
        public int Codigo;
        public float LitrosLeiteProduzido;
        public float AlimQuilos;
        public char Abate;
        public int MesNascimento;
        public int AnoNascimento;
    }

    static void lerDados(List<Gado> lista)
    {
        Gado novoGado = new Gado();
        Console.WriteLine("Digite o código do animal:");
        novoGado.Codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Litros de leite produzido:");
        novoGado.LitrosLeiteProduzido = float.Parse(Console.ReadLine());
        Console.WriteLine("Quilos de Alim ingerido:");
        novoGado.AlimQuilos = float.Parse(Console.ReadLine());
        Console.WriteLine("Mes de nascimento do animal:");
        novoGado.MesNascimento = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ano de nascimento do animal:");
        novoGado.AnoNascimento = Convert.ToInt32(Console.ReadLine());

        //Sistema do abate.
        int idade = novoGado.AnoNascimento - 2023;
        idade = -idade;
        if(idade > 5 || novoGado.LitrosLeiteProduzido < 40)
        {
            novoGado.Abate = 'S';
            Console.WriteLine("Esse animal irá para o abate.");
        }
        else
        {
            novoGado.Abate = 'N';
            Console.WriteLine("Esse animal não irá para o abate.");
        }

        lista.Add(novoGado);
        Console.WriteLine("Leitura realizada com sucesso!");
    }

    static void TotalLeiteSemana(List<Gado> lista)
    {
        float total=0;
        int qtd = lista.Count();

        for(int i = 0; i < qtd; i++)
        {
            total += lista[i].LitrosLeiteProduzido; 
        }

        Console.WriteLine("O total de leite na semana na fazenda:" + total);
    }

    static void AlimentoConsumidoSemana(List<Gado> lista)
    {
        float total = 0;

        foreach (Gado g in lista)
        {
            total += g.AlimQuilos;
        }

        Console.WriteLine("Quantidade total de alimento consumido por semana:" + total);
    }
   
    static void Main()
    {
        List<Gado> lista = new List<Gado>();

    }


}
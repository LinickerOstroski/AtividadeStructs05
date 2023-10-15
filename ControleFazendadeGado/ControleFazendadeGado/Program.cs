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

    static void ListarAnimaisAbate(List<Gado> lista)
    {
        Console.WriteLine("Animais que irão para o abate");
        foreach (Gado g in lista)
        {
            if (g.Abate == 'S')
            {
                Console.WriteLine($"Código do animal: {g.Codigo}");
            }
        }
    }

    static int menu()
    {
        Console.WriteLine("\t*** Controle de gados da fazenda ***");

        Console.WriteLine("0-Cadastrar novo animal");
        Console.WriteLine("1-Retornar a quantidade total de leite produzida por semana");
        Console.WriteLine("2-Retornar a quantidade total de alimento consumido por semana");
        Console.WriteLine("3-Listar animais que devem ir para o abate");
        Console.WriteLine("4-Sair do programa");

        int op = int.Parse(Console.ReadLine());

        return op;
    }
    static void Main()
    {
        List<Gado> lista = new List<Gado>();
        bool programa = true;

        do
        {
            int operador = menu();
            switch (operador)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;

            }
        } while (programa);

        Console.ReadKey();
        Console.Clear();

    }


}
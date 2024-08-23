using System.Security.Cryptography.X509Certificates;

class Program
{




    static void Main(string[] args)
    {
        int opcao = -1;
        while (opcao != 0)
        {
            Console.Clear();
            Console.WriteLine("####################");
            Console.WriteLine("# Loja de Produtos # ");
            Console.WriteLine("####################");
            Console.WriteLine("");
            Console.WriteLine("1 -- Adicionar produto");
            Console.WriteLine("2 -- Listar produto");
            Console.WriteLine("3 -- Editar produto");
            Console.WriteLine("4 -- Excluir produto");
            Console.WriteLine("0 -- Encerrar programa");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1: Produto.Adicionar(); break;
                case 2: Produto.Listar(); break;
                case 3: Produto.Editar(); break;
                case 4: Produto.Excluir(); break;
                case 0: Console.Clear(); System.Console.WriteLine("programa finalizado!"); break;
                default: Console.Clear(); System.Console.WriteLine("opção invalida, faça novamente!"); Thread.Sleep(1500); break;

            }
        }

    }



}
public class Produto
{

    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Valor { get; set; }



    Produto(string nome, int quantidaade, double valor)
    {

        Nome = nome;
        Quantidade = quantidaade;
        Valor = valor;
    }

    public static List<Produto> produtos = new List<Produto>();
    public static void Adicionar()
    {
        bool continuaLacosRepeticao = true;
        while (continuaLacosRepeticao)
        {
            Console.Clear();
            System.Console.WriteLine("#######################");
            System.Console.WriteLine("# Adicionando produto #");
            System.Console.WriteLine("#######################");
            System.Console.WriteLine("");
            System.Console.WriteLine("Nome do produto:");
            string nome = Console.ReadLine();
            System.Console.WriteLine($"Qual é a quantidade d(o) {nome}:");
            int quantidade = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Qual é o valor d(o) {nome}");
            double valor = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, quantidade, valor);
            produtos.Add(produto);

            Console.Clear();
            Console.WriteLine("Produto adicionado com sucesso!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Escolha uma das opções abaixo:");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 -- Adicionar outro produto:");
            System.Console.WriteLine("2 -- Voltar ao Menu principal:");
            System.Console.WriteLine("3 -- Listar  produto:");
            System.Console.WriteLine("");
            System.Console.WriteLine("0 -- Encerrar o programa:");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                Console.Clear(); System.Console.WriteLine("programa encerrado.");
                Environment.Exit(0);

            }

            else if (opcao == 1)
            {
                continue;

            }
            else if (opcao == 3)
            {

                Listar();
                continuaLacosRepeticao = false;
            }
            else if (opcao == 2)
            {
                Console.Clear();
                int vezes = 0;
                for (int i = 3; i > vezes; i--)
                {
                    System.Console.WriteLine($"voltando ao menu principal em ....{i} ");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                continuaLacosRepeticao = false;

            }

        }





    }


    public static void Listar()
    {
        bool continuaLacosRepeticao = true;
        while (continuaLacosRepeticao)
        {
            Console.Clear();
            System.Console.WriteLine("#######################");
            System.Console.WriteLine("# Listando produtos  #");
            System.Console.WriteLine("#######################");
            System.Console.WriteLine("");

            foreach (Produto produto in produtos)

            {

                System.Console.WriteLine($"nome do produto: {produto.Nome}. Quantidade do produto: {produto.Quantidade}.  Valor do produto: {produto.Valor}.");
                System.Console.WriteLine("");

            }
            System.Console.WriteLine("====================================================|");
            System.Console.WriteLine("Todos os produtos foram listados!");
            System.Console.WriteLine("====================================================|");
            System.Console.WriteLine("pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Escolha uma das opções abaixo:");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 -- Para listar novamente:");
            System.Console.WriteLine("2 -- Voltar ao menu principal:");
            System.Console.WriteLine("");
            System.Console.WriteLine("0 -- Encerrar programa:");
            short opcao = short.Parse(Console.ReadLine());


            if (opcao == 0)
            {
                Console.Clear();
                System.Console.WriteLine("Programa encerrado...");
                Environment.Exit(0);
            }
            else if (opcao == 2)
            {
                Console.Clear();
                int vezes = 0;
                for (int i = 3; i > vezes; i--)
                {

                    System.Console.WriteLine($"Voltando ao menu principal em ...{i} segundos");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                continuaLacosRepeticao = false;

            }
            else if (opcao == 1)
            {
                Console.Clear();

            }
        }



    }



    public static void Editar()
    {

        Console.Clear();
        System.Console.WriteLine("#######################");
        System.Console.WriteLine("# Editando produtos  #");
        System.Console.WriteLine("#######################");
        System.Console.WriteLine("");


        System.Console.WriteLine("digite o nome do produto que deseja editar:");
        string nomeProduto = Console.ReadLine();
        Console.Clear();


        Produto produto1 = produtos.Find(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

        if (produto1 != null)
        {
            Console.Clear();
            System.Console.WriteLine($"Nome do produto encontrado é {produto1.Nome}:");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Digite o novo nome para o produto {produto1.Nome}");
            produto1.Nome = Console.ReadLine();
            System.Console.WriteLine($"Digite o nova quantidade do produto {produto1.Nome}");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Digite o novo valor do produto {produto1.Nome} ");
            produto1.Valor = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("");
            System.Console.WriteLine("Produto editado com sucesso!");
        }
        else
        {

            System.Console.WriteLine("Produto nao encontrado!");
        }
        System.Console.WriteLine("Precione qualque tecla para voltar ao menu principal");
        Console.ReadKey();


    }



    public static void Excluir()
    {
        Console.Clear();
        System.Console.WriteLine("#######################");
        System.Console.WriteLine("# Excluir produtos  #");
        System.Console.WriteLine("#######################");
        System.Console.WriteLine("");


        System.Console.WriteLine("Digite o nome do produto que deseja excluir ");
        string nomeProduto = Console.ReadLine();


        Produto produto1 = produtos.Find(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
        if (produto1 != null)
        {
            System.Console.WriteLine("Produto encontrado!");
            System.Console.WriteLine("");
            System.Console.WriteLine($"o nome do produto que você deseja excluir é {produto1.Nome}?");
            System.Console.WriteLine("1 -- Sim");
            System.Console.WriteLine("2 -- não , Excluir outro produto.");
            int opcao3 = int.Parse(Console.ReadLine());
            if (opcao3 == 1)
            {
                Console.Clear();
                produtos.Remove(produto1);

                System.Console.WriteLine("Produto removido com sucesso!");
                Console.ReadKey();
            }
            else if (opcao3 == 2)
            {
                Thread.Sleep(1500);
                Excluir();
            }
        }
        else
        {
            Console.Clear();
            System.Console.WriteLine("Produto não encontrado!");
            System.Console.WriteLine("==========================");
            System.Console.WriteLine("Escolha uma das opçôes abaixo:");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 -- Voltar ao menu principal: ");
            System.Console.WriteLine("2 -- Excluir produto:");
            System.Console.WriteLine("");
            System.Console.WriteLine("3 -- Encerrar programa:");
            short opcao1 = short.Parse(Console.ReadLine());
            switch (opcao1)
            {
                case 1: return;
                case 2: Excluir(); break;
                case 3: Environment.Exit(0); break;
            }

        }

        Console.Clear();
        System.Console.WriteLine("Escolha uma opção abaixo");
        System.Console.WriteLine("");
        System.Console.WriteLine("1 -- Excluir outro produto:");
        System.Console.WriteLine("2 -- Voltar ao menu principal:");
        System.Console.WriteLine("3 -- Encerrar  programa:");
        System.Console.WriteLine("4 -- Listar novamente:");
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Excluir(); break;
            case 2: break;
            case 3: Environment.Exit(0); Console.Clear(); System.Console.WriteLine("Programa encerrado..."); break;
            case 4: Listar(); break;
        }
    }


}

















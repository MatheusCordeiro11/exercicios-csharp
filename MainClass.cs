class MainClass
{
    static void Main(string[] args)
    {
        //Criando produtos
        Produto produto1 = new Produto();
        Produto produto2 = new Produto("Pacote de pão", 12.45f, 15, "Pães embalados");
        Produto produto3 = new Produto("Pacote de café", 30.00f, 15, "Pacote de café solúvel");
        
        Console.WriteLine("--------------------------");
        //Mostrando preço original
        Console.WriteLine("Preço original do produto 2: R$ {0}", produto2.Preco);
        //Aplicando desconto em um deles
        produto2.AplicarDesconto(10);
        Console.WriteLine("Preço com desconto: R$ {0:F2}", produto2.Preco);
        Console.WriteLine("--------------------------");

        Console.WriteLine("--------------------------");
        //Mostrando quantidade original
        Console.WriteLine("Quantidade do produto 3: {0}", produto3.Quantidade);
        //Realizando venda
        produto3.Vender(30);
        produto3.Vender(5);
        Console.WriteLine("Quantidade do produto 3: {0}", produto3.Quantidade);
        produto3.Repor(2);
        Console.WriteLine("Quantidade do produto 3: {0}", produto3.Quantidade);
        Console.WriteLine("--------------------------");

        Console.WriteLine("--------------------------");
        produto1.ExibirInfo();
        produto2.ExibirInfo();
        produto3.ExibirInfo();
        Console.WriteLine("--------------------------");

        


    }
}
class Produto
{
    // Criação de atributos
    private string nome;
    private float preco;
    private int quantidade;
    private string categoria;
    
    // Atributo estático
    private static int totalProdutosCriados = 0;
    
    // Criação de Propriedades
    public string Nome
    {
        get { return nome; }
    }
    
    public float Preco
    {
        get { return preco; }
        set
        {
            if (value > 0.0)
            {
                preco = value;  // ← corrigido: era 'nome'
            }
            else
            {
                preco = 0.0f;   // ← corrigido: era 'nome'
            }
        }
    }
    
    public int Quantidade
    {
        get { return quantidade; }
        set
        {
            if (value > 0)
            {
                quantidade = value;
            }
            else
            {
                quantidade = 0;
            }
        }
    }
    
    public string Categoria
    {
        get { return categoria; }
    }
    
    public static int TotalProdutosCriados
    {
        get { return totalProdutosCriados; }
    }

    // Criação dos construtores
    public Produto()
    {
        nome = "Desconhecido";
        preco = 0.0f;
        quantidade = 0;
        categoria = "Geral";
        ++totalProdutosCriados;
    }
    
    public Produto(string Nome, float Preco, int Quantidade, string Categoria)
    {
        this.nome = Nome;
        this.preco = Preco;
        this.quantidade = Quantidade;
        this.categoria = Categoria;
        ++totalProdutosCriados;
    }
    
    // Métodos
    public void AplicarDesconto(float percentual)
    {
        if (percentual < 0)
        {
            Console.WriteLine("Percentual de desconto não pode ser negativo!");
            return;
        }
        
        float novoPreco = preco - (preco * percentual / 100);
        
        if (novoPreco < 0)
        {
            Console.WriteLine("Desconto muito alto! O preço não pode ficar negativo.");
            preco = 0;
        }
        else
        {
            preco = novoPreco;
            Console.WriteLine($"Desconto de {percentual}% aplicado. Novo preço: R$ {preco:F2}");
        }
    }
    
    public void Vender(int quantidadeVendida)
    {
        if (quantidadeVendida > 0 && quantidade >= quantidadeVendida)
        {
            quantidade -= quantidadeVendida;
            Console.WriteLine($"Venda de {quantidadeVendida} unidades realizada. Estoque restante: {quantidade}");
        }
        else
        {
            Console.WriteLine("Venda não aprovada por falta de estoque.");
        }
    }
    
    public void Repor(int quantidadeReposta)
    {
        if (quantidadeReposta > 0)
        {
            quantidade += quantidadeReposta;
            Console.WriteLine($"Reposição de {quantidadeReposta} unidades realizada. Estoque atual: {quantidade}");
        }
        else
        {
            Console.WriteLine("Quantidade para reposição inválida.");
        }
    }
    
    public void ExibirInfo()
    {
        Console.WriteLine($"Informações do Produto: Nome: {nome} / Preço: R${preco:F2} / Quantidade: {quantidade} / Categoria: {categoria}");
        Console.WriteLine($"Total de Produtos Criados: {totalProdutosCriados}");
    }
}
class Pessoa
{
    //Atributos
    private string nome;
    private string endereco;
    private string telefone;

    //Propriedades 
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }

    public string Endereco
    {
        get
        {
            return endereco;
        }
        set
        {
            endereco = value;
        }
    }

    public string Telefone
    {
        get
        {
            return telefone;
        }
        set
        {
            telefone = value;
        }
    }

    //Construtores
    public Pessoa()
    {
        Nome = "Sem nome";
        Endereco = "Sem endereco";
        Telefone = "(00)00000-0000";
    }

    public Pessoa(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }
}
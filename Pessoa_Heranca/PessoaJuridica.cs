class PessoaJuridica : Pessoa
{
    //Atributos
    private string cnpj;
    
    //Propriedades
    public string Cnpj
    {
        get
        {
            return cnpj;
        }
        set
        {
            cnpj = value;
        }
    }

    //Construtor
    public PessoaJuridica() : base()
    {
        this.cnpj = "0000000/0000000";
    }
    
    public PessoaJuridica(string nome, string endereco, string telefone, string cnpj) : base (nome, endereco, telefone)
    {
        this.cnpj = cnpj;
    }
}

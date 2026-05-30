class PessoaFisica : Pessoa
{
    //Atributos
    private string cpf;

    //Propriedades
    public string Cpf
    {
        get
        {
            return cpf;
        }
        set
        {
            cpf = value;
        }
    }
    //Construtor
    public PessoaFisica() : base ()
    {
        this.cpf = "000.000.000-00";
    }

    public PessoaFisica(string nome, string endereco, string telefone, string cpf) : base(nome, endereco, telefone)
    {
        this.cpf = cpf;
    }
}
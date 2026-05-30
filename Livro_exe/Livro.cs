class Livro{
    //Atributos
    private string titulo;
    private string autor;
    private string isbn;
    private int anoPublicacao;
    private bool disponivel;
    private int codigoIdentificacao = 1000;
    //Atributo estático
    private static int ultimoCodigo;

    //Propriedades
    public string Titulo{
        get{return titulo;}
    }

    public string Autor{
        get{return autor;}
    }

    public string Isbn{
        get{return isbn;}
    }

    public int AnoPublicacao{
        get{return anoPublicacao;}
        set{
            if(value >= 1450 && value <= DateTime.Now.Year){
                anoPublicacao = value;
            }
            else{
                anoPublicacao = 2000;
            }
        }
    }

    public bool Disponivel{
        get{return disponivel;}
        set{
            disponivel = value;
        }
    }

    public int CodigoIdentificacao{
        get{return codigoIdentificacao;}
    }

    //Construtores
    public Livro(){
        titulo = "Sem título";
        autor = "Desconhecido";
        isbn = "000-0-00-000000-0";
        anoPublicacao = 2000;
        disponivel = true;
        ultimoCodigo = codigoIdentificacao;
        ++codigoIdentificacao;
    }

    public Livro(string titulo, string autor, string isbn, int anoPublicacao){
        //Validação de strings vazias
        if(string.IsNullOrEmpty(titulo)){
            this.titulo = "Sem título";
        }
        else{
            this.titulo = titulo;
        }
        if(string.IsNullOrEmpty(autor)){
            this.autor = "Desconhecido";
        }
        else{
            this.autor = autor;
        }
        if(string.IsNullOrEmpty(isbn)){
            this.isbn = "000-0-00-000000-0";
        }
        else{
            this.isbn = isbn;
        }

        this.AnoPublicacao = anoPublicacao;
        this.Disponivel = true;
    }

    //Métodos
    public bool Emprestar(){
        if(disponivel == true){
            disponivel = false;
            Console.WriteLine("{0} emprestado com sucesso.", titulo);
            return true;
        }
        else{
            Console.WriteLine("{0} está indisponível no momento.", titulo);
            return false;
        }
    }

    public void Devolver(){
        disponivel = true;
        Console.WriteLine("{0} devolvido com sucesso.", titulo);
    }

    public void ExibirDetalhes(){
        Console.WriteLine("===== LIVRO =====");
        Console.WriteLine("Título: {0}", Titulo);
        Console.WriteLine("Autor: {0}", Autor);
        Console.WriteLine("ISBN: {0}", Isbn);
        Console.WriteLine("Ano: {0}", AnoPublicacao);
        Console.WriteLine("Status: {0}", Disponivel);
        Console.WriteLine("=================");
    }
}
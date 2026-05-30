public abstract class Midia{
    //Atributos
    private string titulo;
    private int anoLancamento;
    private int duracaoSegundos;

    //Propriedades
    public string Titulo{
        get{return titulo;}
        set{
            if(!string.IsNullOrEmpty(value)){
                titulo = value;
            }
            else{
                titulo = "Título desconhecido";
            }
        }
    }
    public int AnoLancamento{
        get{return anoLancamento;}
        set{
            if(value >= 1888 && value <= DateTime.Now.Year){
                anoLancamento = value;
            }
            else{
                anoLancamento = 2024;
            }
        }
    }
    public int DuracaoSegundos{
        get{return duracaoSegundos;}
        set{
            if(value > 0){
                duracaoSegundos = value;
            }
            else{
                duracaoSegundos = 60;
            }
        }
    }
    //Construtor
    public Midia(string titulo, int anoLancamento, int duracaoSegundos){
        this.Titulo = titulo;
        this.AnoLancamento = anoLancamento;
        this.DuracaoSegundos = duracaoSegundos;
    }
    //Métodos
    public abstract void ExibirInfo();

    public virtual string ObterDuracaoFormatada()
    {
        int Xminutos = 0;
        int Ysegundos = 0;
        Xminutos = DuracaoSegundos / 60;
        Ysegundos = DuracaoSegundos % 60;
        return $"{Xminutos} minutos e {Ysegundos} segundos";
    }

    public virtual string GetTipo(){
        return "Mídia genérica";
    }
}
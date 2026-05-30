public class Video : Midia{
    //Atributos
    private string resolucao;
    //Propriedades
    public string Resolucao{
        get{return resolucao;}
        set{
            if(!string.IsNullOrEmpty(value)){
                resolucao = value;
            }
            else{
                resolucao = "720p";
            }
        }
    }
    //Construtor
    public Video(string titulo, int anoLancamento, int duracaoSegundos, string resolucao) : base(titulo, anoLancamento, duracaoSegundos){
        this.Resolucao = resolucao;
    }
    //Métodos
    public override void ExibirInfo(){
        Console.WriteLine("=== MÍDIA ===");
        Console.WriteLine($"Nome: {Titulo}");
        Console.WriteLine($"Ano de Lancamento: {AnoLancamento}");
        Console.WriteLine($"Duração da mídia: {ObterDuracaoFormatada()}");
        Console.WriteLine($"Resolucao: {resolucao}");
    }
    public override string GetTipo(){
        return "Video";
    }
}
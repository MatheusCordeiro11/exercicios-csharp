public class Musica : Midia{
    //Atributos
    private string artista;
    private string album;

    //Propriedades 
    public string Artista{
        get{return artista;}
        set{
            if(!string.IsNullOrEmpty(value)){
                artista = value;
            }
            else{
                artista = "Artista desconhecido";
            }
        }
    }
    public string Album{
        get{return album;}
        set{
            if(!string.IsNullOrEmpty(value)){
                album = value;
            }
            else{
                album = "Single";
            }
        }
    }
    //Construtor
    public Musica(string titulo, int anoLancamento, int duracaoSegundos, string artista, string album) : base(titulo, anoLancamento, duracaoSegundos){
        this.Artista = artista;
        this.Album = album;
    }
    //Métodos
    public override void ExibirInfo(){
        Console.WriteLine("=== MÍDIA ===");
        Console.WriteLine($"Nome: {Titulo}");
        Console.WriteLine($"Ano de Lancamento: {AnoLancamento}");
        Console.WriteLine($"Duração da mídia: {ObterDuracaoFormatada()}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Álbum: {Album}");
    }
    public override string GetTipo(){
        return "Música";
    } 
    public bool EUmHit(){
        return (DateTime.Now.Year - AnoLancamento) < 3;   
    }
}
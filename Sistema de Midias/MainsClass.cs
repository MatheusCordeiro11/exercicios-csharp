using System;

public class MainClass{
    public static void Main(string[] args){
        //Criando um vetor para Midias
        int contMidia = 0;
        int totalReproducao = 0;
        Midia[] midias = new Midia[5];
        midias[contMidia++] = new Video("Programador Primata", 2026, 500, "1080p");
        midias[contMidia++] = new Video("Cazé TV", 2026, 800, "4K");
        midias[contMidia++] = new Musica("Amanhecer", 2024, 600, "BK", "ICARUS");
        midias[contMidia++] = new Musica("Musicas de Amor Nunca Mais", 2025, 600, "BK", "ICARUS");
        midias[contMidia++] = new Video("Mica Galvão x Leandro Lo", 2019, 800, "1080p");
        //Percorrer o vetor para aparecer as informações de cada midia
        for(int i = 0; i < contMidia; i++){
            midias[i].ExibirInfo();
            midias[i].GetTipo();
        }
        //Calculando o tempo total de reprodução da playlist 
        for(int j = 0; j < contMidia; j++){
            totalReproducao += midias[j].DuracaoSegundos;
        }
        Console.WriteLine($"O tempo total da playlist criada é de {totalReproducao} segundos");
        //Mostrando as musicas hits
        for(int k = 0; k < contMidia; k++){
            if(midias[k] is Musica musica && musica.EUmHit()){
                Console.WriteLine($"A música {midias[k].Titulo} é um HIT!");
            }
        }    
    }
}
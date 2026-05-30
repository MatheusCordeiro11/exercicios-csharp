using System.Drawing;

class Quadrado : Figura
{
    //Construtor
    public Quadrado(int x, int y, int lado, Color cor, bool preenchido) : base(x, y, lado, cor, preenchido){
        
    }
    //Métodos abstratos
    public override void Desenha(){
        Console.WriteLine($"Desenhando um quadrado na posição ({X},{Y}), com tamanho {Lado} a cor {Cor}.");
    }
    public override void Area(){
        int area = Lado * Lado;
        Console.WriteLine($"A área do quadrado de posição ({X}, {Y}) com tamanho {Lado} é {area}.");
    }
    public override void Perimetro(){
        int perimetro = Lado * 4;
        Console.WriteLine($"O perímetro do quadrado de posição ({X}, {Y}) com tamanho {Lado} é {perimetro}.");
    }
}
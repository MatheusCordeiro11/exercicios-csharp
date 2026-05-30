using System.Drawing;

class Circulo : Figura
{
    //Construtor
    public Circulo(int x, int y, int lado, Color cor, bool preenchido) : base(x, y, lado, cor, preenchido){
        
    }
    //Métodos abstratos
    public override void Desenha(){
        Console.WriteLine($"Desenhando um círculo na posição ({X},{Y}), com tamanho {Lado} a cor {Cor}.");
    }
    public override void Area(){
        double area = Math.PI * Lado * Lado;  // Lado aqui é o raio
        Console.WriteLine($"A área do círculo na posição ({X}, {Y}) com raio {Lado} é {area:F2}");
    }
    public override void Perimetro(){
        double perimetro = 2 * Math.PI * Lado;
        Console.WriteLine($"O perímetro (circunferência) do círculo na posição ({X}, {Y}) com raio {Lado} é {perimetro:F2}");
    }
}
using System.Drawing;

class MainClass{    
    public static void Main(string[] args){
        
        Figura[] figuras = new Figura[3];
        int numFig = 0;

        figuras[numFig++] = new Quadrado(10, 20, 50, Color.Red, true);
        figuras[numFig++] = new Circulo(213, 78, 80, Color.Navy, true);
        figuras[numFig++] = new Quadrado(95, 4, 120, Color.Brown, true);

        for(int pos = 0; pos < numFig; pos++) 
        {
          Console.WriteLine($"\n--- Figura {pos + 1} ---");
          figuras[pos].Desenha();
          figuras[pos].Area();
          figuras[pos].Perimetro();      
        }
    }   
}
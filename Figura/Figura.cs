using System.Drawing;

public abstract class Figura{
    //Atributos
    private int x;
    private int y;
    private int lado;
    private Color cor;
    private bool preenchido;

    //Propriedades
    public int X{
        get{ return x;}
        set{
            if(value > 0){
                x = value;
            }
            else{
                x = 1;
            }
        }
    }
    public int Y{
        get{return y;}
        set{
            if(value > 0){
                y = value;
            }
            else{
                y = 1;
            }
        }
    }
    public int Lado{
        get{return lado;}
        set{
            if(value > 1){
                lado = value;
            }
            else{
                lado = 1;
            }
        }
    }
    public Color Cor{
        get{return cor;}
        set{
            cor = value;
        }
    }
    public bool Preenchido{
        get{return preenchido;}
        set{
            preenchido = value;
        }
    }

    //Construtores
    public Figura(int x, int y, int lado, Color cor, bool preenchido){
        X = x;
        Y = y;
        Lado = lado;
        Cor = cor;
        Preenchido = preenchido;
    }
    //Métodos abstratos não possuem implementação
    public abstract void Desenha();
    public abstract void Area();
    public abstract void Perimetro();
}

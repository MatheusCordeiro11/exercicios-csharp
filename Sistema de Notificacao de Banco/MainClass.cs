public class MainClass
{
    //Métodos para reagir ao evento;
    public static void ExibirNotificacao(string mensagem)
    {
        Console.WriteLine($"[NOTIFICAÇÃO]: {mensagem}");
    }
    public static void RegistrarLog(string mensagem)
    {
        Console.WriteLine($"[LOG]: {mensagem}");
    }

    public static void Main(string[] args)
    {
        //Criando uma conta corrente e uma conta poupanca;
        ContaCorrente contaCorrente1 = new ContaCorrente("Matheus Cordeiro Berto", 6000.00, "1");
        ContaPoupanca contaPoupanca1 = new ContaPoupanca("Raquel Cordeiro Berto", 500.00, "2");
      
        //Inscrevendo os métodos no evento de cada um
        contaCorrente1.AoMovimentar += ExibirNotificacao;
        contaCorrente1.AoMovimentar += RegistrarLog;

        contaPoupanca1.AoMovimentar += ExibirNotificacao;
        contaPoupanca1.AoMovimentar += RegistrarLog;


        contaCorrente1.Depositar(1000);
        contaCorrente1.Sacar(200);
        contaPoupanca1.Depositar(300);
        contaPoupanca1.AplicarRendimento(0.05);

    }
}
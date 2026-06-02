public class ContaPoupanca : Conta
{
    //Construtor
    public ContaPoupanca(string titular, double saldo, string numeroConta) : base(titular, saldo, numeroConta)
    {
        
    }
    //Métodos
    public void AplicarRendimento(double percentual)
    {
        double valorFinal;
        valorFinal = Saldo * percentual;
        Saldo += valorFinal;
        DispararNotificacao($"O percentual de {percentual}% foi aplicado com sucesso.");
        DispararNotificacao($"Saldo atual: R${Saldo}.");
    }
    //Métodos abstratos
    public override void Depositar(double valor)
    {
        Saldo += valor;
        DispararNotificacao($"Valor de R$ {valor} depositado com sucesso.");
        DispararNotificacao($"Saldo atual: R${Saldo}.");
    }
    public override void Sacar(double valor)
    {
        if(Saldo > 0 && Saldo >= valor)
        {   
            Saldo -= valor;
            DispararNotificacao($"O valor de R${valor} foi sacado da conta com sucesso.");
            DispararNotificacao($"Saldo atual: R${Saldo}.");
        }
    }
}
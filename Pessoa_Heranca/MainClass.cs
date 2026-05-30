class MainClass
{
    static void Main(string[] args)
    {
        //Criando pessoa fisica e juridica
        PessoaFisica pessoaFisica1 = new PessoaFisica("Matheus", "Rua Jaboticatubas 471", "(31)99311-8659", "117.032.136-45");

        PessoaJuridica pessoaJuridica1 = new PessoaJuridica("Fernanda", "Rua Jaboticatubas 471", "(31)99999-9999", "00000/0005000");

         // Exibindo os dados
        Console.WriteLine("=== PESSOA FÍSICA 1 ===");
        Console.WriteLine($"Nome: {pessoaFisica1.Nome}");
        Console.WriteLine($"Endereço: {pessoaFisica1.Endereco}");
        Console.WriteLine($"Telefone: {pessoaFisica1.Telefone}");
        Console.WriteLine($"CPF: {pessoaFisica1.Cpf}");

        Console.WriteLine("=== PESSOA JURIDICA 1 ===");
        Console.WriteLine($"Nome: {pessoaJuridica1.Nome}");
        Console.WriteLine($"Endereço: {pessoaJuridica1.Endereco}");
        Console.WriteLine($"Telefone: {pessoaJuridica1.Telefone}");
        Console.WriteLine($"CPF: {pessoaJuridica1.Cnpj}");
    }
}
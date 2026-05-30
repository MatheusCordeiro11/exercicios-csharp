class MainClass{
    public static void Main(string[] args){

        //Criando os objetos livro
        Livro livro1 = new Livro();
        Livro livro2 = new Livro("O Senhor dos Anéis", "J. R. R. Tolkien", "9786555114249", 1954);
        Livro livro3 = new Livro("Diario de um banana", "Matheus Cordeiro", "9786555114249", 2002);

        Console.WriteLine("=== Detalhes de cada livro cadaatrados ===");
        livro1.ExibirDetalhes();
        livro2.ExibirDetalhes();
        livro3.ExibirDetalhes();

        //Emprestando livro
        Console.WriteLine("=================");
        livro2.Emprestar();
        Console.WriteLine("=================");
        //Emprestando o mesmo livro novamente
        livro2.Emprestar();
        Console.WriteLine("=================");
        livro2.ExibirDetalhes();
        Console.WriteLine("=================");
        //Devolvendo o livro
        livro2.Devolver();
        Console.WriteLine("=================");
    }
}
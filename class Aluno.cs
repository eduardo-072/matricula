class Aluno
{
    public int rm;
    public  string nome = default!;
    public int idade;
    public bool ativo = true;
 
    public void Exibir()
    {
        string mensagem = $"O aluno(a) {this.nome} possui o rm {this.rm}.";
        Console.WriteLine(mensagem);
    }
    public void TrancaMatricula()
    {
        this.ativo = false;
    }
 
}
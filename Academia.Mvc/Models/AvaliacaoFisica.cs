namespace Academia;

public class AvaliacaoFisica
{
    public int Id {get; set;}
    public DateTime Data {get; set;} //Data da avaliacao fisica
    public decimal Peso {get; set;} // Peso do aluno na avaliaçao fisica
    public string? Observacoes {get; set;}
    public int AlunoId {get; set;}
    public Aluno? Aluno {get; set;} //
}
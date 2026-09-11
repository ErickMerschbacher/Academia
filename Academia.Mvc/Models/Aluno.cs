namespace Academia;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty; //Nome do aluno, = strong.Empty significa valor vazio.
    public DateTime DataNascimento { get; set;}
    public string? UserId { get; set;} //Id do usuario associado ao aluno
    public List<Matricula>? Matriculas { get; set; }
    public List<AvaliacaoFisica>? Avaliacoes { get; set; } //Lista de avaliaçoes físicas associadas ao aluno.
    public List <Inscricao>? Inscricoes { get; set; } // Lista de inscrições associadas ao aluno. ? significa que a lista de inscriçoes pode ser nula, ou seja, o aluno pode não ter nenhuma inscrição.
    
}

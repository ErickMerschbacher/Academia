namespace Academia;

public class Matricula
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; } // Id do aluno associado a matrícula 
    public int AlunoId { get; set; } // Id do aluno associado à matrícula
    public Aluno? Aluno {get; set;} // Referência ao aluno associado à matrícula 
    public Plano? Plano {get; set;} //Referência ap plano associado a matricula
}

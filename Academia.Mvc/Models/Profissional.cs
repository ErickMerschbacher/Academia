namespace Academia;

public class Profissional
{
    public int Id { get; set;}
    public string Nome ( get; set; ) = string.Empty; // Nome do profissional, = string.Empty significa valor vazio.
    public string Especialidade { get; set; } = string.Empty; // Especialidade (Ex: Musculação, Pilates, Nutrição), = string.Empty significa valor vazio.
    
}

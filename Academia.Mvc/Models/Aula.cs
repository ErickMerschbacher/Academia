namespace Academia;

public class Aula
{
    public int Id {get; set;}
    public String Nome {get; set; } = string.Empty;
    public DayOfWeek DiaDaSemana {get; set;} //Dia da semana de aula
    public TimeSpan Horario {get; set;}
    public int VagasTotais {get; set;}
    public int ProfissionaisId {get; set;}
}

namespace ManagerDAS.Entities;

public class Beneficiar
{
    public int BeneficiarId { get; set; }

    public string Nume { get; set; }

    public ConsilierDeProbatiune ManagerCaz { get; set; }

    public ProgramDAS ProgramDAS { get; set; }
}
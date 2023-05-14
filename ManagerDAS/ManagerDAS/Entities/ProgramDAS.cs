using System;

namespace ManagerDAS.Entities;

public enum Modul
{
    AFaceOCriticaConstructivă,
    Comunicare,
    CumTePrezințiInFataUnuiAngajator,
    ManagementulConflictelor
}

public class ProgramDAS
{
    public int ProgramDASId { get; set; }


    public Modul Modul { get; set; }


    public DateTime DataInceput { get; set; }


    public DateTime DataSfarsit { get; set; }


    public ConsilierDeProbatiune Trainer1 { get; set; }


    public ConsilierDeProbatiune Trainer2 { get; set; }
}
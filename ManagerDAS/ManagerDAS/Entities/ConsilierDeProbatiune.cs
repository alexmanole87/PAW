using System;

namespace ManagerDAS.Entities;

public enum Studii
{
    Drept,
    AsistenaSociala,
    Sociologie,
    Psihologie
}

public class ConsilierDeProbatiune
{
    public int ConsilierDeProbațiuneId { get; set; }


    public string Nume { get; set; }


    public DateTime DataIntrariiInSistem { get; set; }


    public Studii Studii { get; set; }


    public bool Abilitat { get; set; }
}
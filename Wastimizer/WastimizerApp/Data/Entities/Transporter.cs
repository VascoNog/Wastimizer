namespace WastimizerApp.Data.Entities;

public class Transporter
{
    public int Id { get; set; }
    public string Code { get; set; } // Is not Required
    public string ShortDesignation { get; set; }
    public string FullDesignation { get; set; }
    public int FiscalNumber { get; set; }
}

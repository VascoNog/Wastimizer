namespace WastimizerApp.Data.Entities;

public class DestinySite
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string ShortDesignation { get; set; }
    public string FullDesignation { get; set; }
    public int FiscalNumber { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
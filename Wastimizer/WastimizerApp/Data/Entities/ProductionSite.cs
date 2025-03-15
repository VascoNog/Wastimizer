namespace WastimizerApp.Data.Entities;

public class ProductionSite
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string ShortDesignation { get; set; }
    public string FullDesignation { get; set; }
    public DateTime ActiveSince { get; set; }

    //Foreign Key of Company
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}
namespace WastimizerApp.Data.Entities;

public class Company
{
    public int Id { get; set; }
    public string ShortDesignation { get; set; }
    public string FullDesignation { get; set; }
    public int FiscalNumber { get; set; }
    public string Email { get; set; }
    public DateTime ActiveSince { get; set; }

    //Foreign Key, in case of a company group
    public int? CompanyGroupId {get; set; } //Nullable to avoid circular reference(Cascade)
    public Company CompanyGroup { get; set; }

}


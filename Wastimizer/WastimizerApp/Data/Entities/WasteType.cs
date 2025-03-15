namespace WastimizerApp.Data.Entities;
public class WasteType
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string ShortDesignation { get; set; }
    public string FullDesignation { get; set; }
    public string Description { get; set; } 
}


//WasteType
//ID  int
//Code    string Required
//ShortDesignation string Required
//FullDesignation string Required
//Description string Not Required

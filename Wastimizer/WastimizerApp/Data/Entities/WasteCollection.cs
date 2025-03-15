namespace WastimizerApp.Data.Entities;
public class WasteCollection
{
    public int Id { get; set; }
    public string Code { get; set; }
    public decimal Tonnage { get; set; }
    public DateTime PickupAt { get; set; }

    //Foreign Keys
    public int TransporterId { get; set; }
    public Transporter Transporter { get; set; }
    public int WasteTypeId { get; set; }
    public WasteType WasteType { get; set; }
    public int RecoverOpId { get; set; }
    public RecoverOperation RecoverOp { get; set; }
    public int ProductionSiteId { get; set; }
    public ProductionSite ProductionSite { get; set; }
    public int DestinySiteId { get; set; }
    public DestinySite DestinySite { get; set; }    
    public int CurrentStatusId { get; set; }
    public CurrentStatusType CurrentStatus { get; set; }
}

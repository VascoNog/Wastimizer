namespace WastimizerApp.Data.Entities;
public class CurrentStatusType
{
    public int Id { get; set; }
    public string Description { get; set; } = "Completed"; // Default value

    // Valores que pode tomar: InProgress, Completed, Voided (Se eGAR for anulada)
}

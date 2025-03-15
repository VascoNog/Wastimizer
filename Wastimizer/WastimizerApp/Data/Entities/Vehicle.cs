namespace WastimizerApp.Data.Entities;

public class Vehicle
{
    public int Id { get; set; }
    public string LicensePlate { get; set; }

    // Foreign Key Transporter
    public int TransporterId { get; set; }
    public Transporter Transporter { get; set; }
}

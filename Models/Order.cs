using API.Abstract;
using API.Data.DTO;
using API.Data.Repositories;

namespace API.Data.Models;

[BsonCollection("Orders")]
public class Order : Document
{
    public int Code { get; set; }
    public Customer? Customer { get; set; }
    public List<OrderItem>? Products { get; set; }
    public double Total { get; set; }
    public double Discount { get; set; }
    public string? Status { get; set; }
    public DateTime AppointmentTime { get; set; }
    public DateTime EndTime { get; set; }
}
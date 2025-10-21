using Papas.Domain.Entities;

namespace Papas.Application.DTOs;

public class OrderSummaryDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = "";
    public decimal Subtotal { get; set; }
    public decimal Total { get; set; }
    public DateTime CreatedAt { get; set; }
}

using Papas.Domain.Entities;

using Papas.Application.DTOs;

namespace Papas.Application.Interfaces;

public interface IOrderService
{
    Task<OrderSummaryDto> CreateOrderAsync(CreateOrderRequest request);
    Task<IEnumerable<OrderSummaryDto>> GetAllOrdersAsync();
    Task<OrderSummaryDto?> GetOrderByIdAsync(int id);
}

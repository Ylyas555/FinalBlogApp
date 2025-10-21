using Blog.Domain.Entities;

using Blog.Application.DTOs;

namespace Blog.Application.Interfaces;

public interface IOrderService
{
    Task<OrderSummaryDto> CreateOrderAsync(CreateOrderRequest request);
    Task<IEnumerable<OrderSummaryDto>> GetAllOrdersAsync();
    Task<OrderSummaryDto?> GetOrderByIdAsync(int id);
}

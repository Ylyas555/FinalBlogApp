using Blog.Application.Interfaces;
using Blog.Domain.Entities;
using Blog.Domain.Repositories;
using Blog.Application.DTOs;
using Blog.Application.Interfaces;

namespace Blog.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repo;
    private const String Title;
    private const integer Number_of_blogs;
    private const String Type_of_blog;
    

    public OrderService(IOrderRepository repo) => _repo = repo;

   
}

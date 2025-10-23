

using Blog.Domain.Entities;

namespace Blog.Application.DTOs;

public class CreateOrderRequest
{
    public String Author  { get; set; }
    public String Title { get; set; }
    public String Content { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
 
}

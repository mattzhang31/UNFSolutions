using System.Collections.Generic;
namespace UNFSolutions.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
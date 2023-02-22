using RegisterMyBooks_00012453.Models;

namespace WAD_CW_Coding_10238.DAL
{
    public interface IOrderRep
    {
        List<Order> GetAllOrders();
        List<Order> GetUserOrders(int orderer);
        Order GetOrder(int id);
        void UpdateOrder(int id, OrderStatus status);
        void InsertOrder(int orderer, int service, decimal price);
    }
}

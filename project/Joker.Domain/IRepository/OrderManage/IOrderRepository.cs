
//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-10 10:04:22 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using Joker.Data;
using Joker.Domain.Entity.OrderManage;

namespace Joker.Domain.IRepository.OrderManage
{
    /// <summary>
    /// OrderRepository
    /// </summary>	
    public interface IOrderRepository : IRepositoryBase<OrderEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(OrderEntity orderEntity, string keyValue);
    }
}




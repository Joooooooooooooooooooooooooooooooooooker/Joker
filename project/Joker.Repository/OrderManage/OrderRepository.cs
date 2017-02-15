
//------------------------------------------------------------------------------
// Joooooooooooker
//     此代码由T4模板自动生成
//	   生成时间 2017-02-10 10:04:33 by joker
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using Joker.Data;
using Joker.Domain.Entity.OrderManage;
using Joker.Domain.IRepository.OrderManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker.Repository.OrderManage
{
    /// <summary>
    /// OrderRepository
    /// </summary>	
    public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<OrderEntity>(t => t.F_Id == keyValue);                
                db.Commit();
            }
        }
        public void SubmitForm(OrderEntity orderEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(orderEntity);
                }
                else
                {
                    db.Insert(orderEntity);
                }
                db.Commit();
            }
        }
    }
}





//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-10 10:04:08 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using Joker.Domain.Entity.OrderManage;
using Joker.Domain.IRepository.OrderManage;
using Joker.Repository.OrderManage;
using System;
using System.Collections.Generic;
using System.Linq;
using Joker.Code;

namespace Joker.Application.OrderManage
{
    /// <summary>
    /// OrderApp
    /// </summary>	
    public class OrderApp
    {
        private IOrderRepository service = new OrderRepository();

        public List<OrderEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public OrderEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(OrderEntity entity)
        {
            service.Delete(entity);
        }

        public void DeleteForm(string keyValue)
        {
            service.DeleteForm(keyValue);
        }

        public void SubmitForm(OrderEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }

        public List<OrderEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<OrderEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_OrderNo.Contains(keyword));               
            }
            return service.FindList(expression, pagination);
        }
        public void UpdateForm(OrderEntity orderEntity)
        {
            service.Update(orderEntity);
        }
    }
}




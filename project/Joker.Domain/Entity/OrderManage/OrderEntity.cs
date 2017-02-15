//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-10 10:04:16 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------

using System;
namespace Joker.Domain.Entity.OrderManage
{
    /// <summary>
    /// OrderEntity
    /// </summary>	
    public class OrderEntity : IEntity<OrderEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string F_OrderNo { get; set; }
        public decimal? F_OrderAmount { get; set; }
        public bool? F_DeleteMark { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

    }
}
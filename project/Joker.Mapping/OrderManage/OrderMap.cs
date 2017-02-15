
//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-10 10:04:27 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using Joker.Domain.Entity.OrderManage;
using System.Data.Entity.ModelConfiguration;
namespace Joker.Mapping.OrderManage
{
    /// <summary>
    /// OrderMap
    /// </summary>	
    public class OrderMap : EntityTypeConfiguration<OrderEntity>
    {
        public OrderMap()
        {
            this.ToTable("Tbl_Order");
            this.HasKey(t => t.F_Id);
        }
    }
}




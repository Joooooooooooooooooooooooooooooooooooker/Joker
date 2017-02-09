/*******************************************************************************
 * Copyright © 2017 Joooooooooooker 版权所有
 * Author: Joooooooooooker
 * Description: Joooooooooooker
 * Website：Joooooooooooker
*********************************************************************************/
using Joker.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace Joker.Mapping.SystemManage
{
    public class RoleAuthorizeMap : EntityTypeConfiguration<RoleAuthorizeEntity>
    {
        public RoleAuthorizeMap()
        {
            this.ToTable("Sys_RoleAuthorize");
            this.HasKey(t => t.F_Id);
        }
    }
}

/*******************************************************************************
 * Copyright © 2017 Joooooooooooker 版权所有
 * Author: Joooooooooooker
 * Description: Joooooooooooker
 * Website：Joooooooooooker
*********************************************************************************/
using Joker.Domain.Entity.SystemSecurity;
using System.Data.Entity.ModelConfiguration;

namespace Joker.Mapping.SystemSecurity
{
    public class FilterIPMap : EntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            this.ToTable("Sys_FilterIP");
            this.HasKey(t => t.F_Id);
        }
    }
}

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
    public class DbBackupMap : EntityTypeConfiguration<DbBackupEntity>
    {
        public DbBackupMap()
        {
            this.ToTable("Sys_DbBackup");
            this.HasKey(t => t.F_Id);
        }
    }
}

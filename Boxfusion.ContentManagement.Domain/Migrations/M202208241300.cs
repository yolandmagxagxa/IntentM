using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.Migration", Version = "1.0")]

namespace Boxfusion.ContentManagement
{
    [Migration(202208241300)]
    public class M202208241300 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {
            Alter.Table("CM_ContentPermissions").AddColumn("Permission").AsString();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
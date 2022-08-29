using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;
using Shesha.FluentMigrator;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.EnumMigration", Version = "1.0")]

namespace Boxfusion.ContentManagement
{
    [Migration(202208240800)]
    public class M202208240800 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {

            

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
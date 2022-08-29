using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;
using Shesha.FluentMigrator;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.Migration", Version = "1.0")]

namespace Boxfusion.Dep
{
    [Migration(202208241200)]
    public class M202208241200 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {

            Create.Table("DEP_Contacts")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("TwitterHandle").AsString()
             .WithColumn("FacebookHandle").AsString()
             .WithColumn("InstaHandle").AsString()
             .WithColumn("LinkedInHandle").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("JobTitle").AsString()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("FlagsLkp").AsInt64().Nullable();


            Create.Table("DEP_EventPresenters")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Description").AsString()
             .WithColumn("Time").AsDateTime();


            Create.Table("DEP_Events")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("StartDate").AsDateTime()
             .WithColumn("EndDate").AsDateTime()
             .WithColumn("Address").AsString()
             .WithColumn("EventLink").AsString()
             .WithColumn("Venue").AsString()
             .WithColumn("Agenda").AsString()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("Lat").AsString()
             .WithColumn("Long").AsString()
             .WithColumn("CategoryLkp").AsInt64().Nullable();


            Create.Table("DEP_FAQs")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Question").AsString()
             .WithColumn("Answer").AsString()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("CategoryLkp").AsInt64().Nullable();


            this.Shesha().ReferenceListCreate("Boxfusion.Dep", "ContactFlags")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.Dep", "EventCategories")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.Dep", "FAQCategories")
                ;

            Alter.Table("DEP_Contacts").AddForeignKeyColumn("PersonId", "Core_Persons");
            Alter.Table("DEP_EventPresenters").AddForeignKeyColumn("EventId", "DEP_Events");
            Alter.Table("DEP_EventPresenters").AddForeignKeyColumn("PersonId", "Core_Persons");
            Alter.Table("DEP_Events").AddForeignKeyColumn("EventImageId", "Core_StoredFiles");
            Alter.Table("DEP_Events").AddForeignKeyColumn("AgendaFileId", "Core_StoredFiles");
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
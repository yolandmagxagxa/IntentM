using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;
using Shesha.FluentMigrator;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.Migration", Version = "1.0")]

namespace Boxfusion.ContentManagement
{
    [Migration(202208241200)]
    public class M202208241200 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {

            Create.Table("CM_ContentAppointments")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("RoleLkp").AsInt64().Nullable();


            Create.Table("CM_ContentFolders")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("DatePublished").AsDateTime()
             .WithColumn("AllowSubFolders").AsBoolean();


            Create.Table("CM_ContentItemBases")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("ImageIconUrl").AsString()
             .WithColumn("AllowLiking").AsBoolean()
             .WithColumn("AllowCommenting").AsBoolean()
             .WithColumn("ValidFrom").AsDateTime()
             .WithColumn("ValidTo").AsDateTime()
             .WithColumn("CanExport").AsBoolean()
             .WithColumn("PublishedDate").AsDateTime()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("Icon").AsString()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("AllowableContentTypeLkp").AsInt64().Nullable()
             .WithColumn("OrderingMethodLkp").AsInt64().Nullable()
             .WithColumn("FlagsLkp").AsInt64().Nullable()
             .WithColumn("PublicationStatusLkp").AsInt64().Nullable()
             .WithColumn("Attribute").AsString();


            Create.Table("CM_ContentItems")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("ContentUrl").AsString()
             .WithColumn("WebPage").AsString();


            Create.Table("CM_ContentPermissions")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("TypeLkp").AsInt64().Nullable();

            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "Roles")
                .AddItem(1, "Approver", 1)
                .AddItem(2, "Admin", 2)
                .AddItem(3, "Both", 3);


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "AllowableContentTypes")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "Flags")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "OrderMethods")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "PermittedUserFlags")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "PublicationStatuses")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ContentManagement", "PermissionTypes")
                .AddItem(1, "Person", 1)
                .AddItem(2, "Organisation", 2)
                .AddItem(3, "Role", 3);

            Alter.Table("CM_ContentAppointments").AddForeignKeyColumn("PersonId", "Core_Persons");
            Alter.Table("CM_ContentAppointments").AddForeignKeyColumn("OwnerId", "CM_ContentItemBases");
            Alter.Table("CM_ContentItems").AddForeignKeyColumn("PreviewImageId", "Core_StoredFiles");
            Alter.Table("CM_ContentItems").AddForeignKeyColumn("ContentId", "Core_StoredFiles");
            Alter.Table("CM_ContentPermissions").AddForeignKeyColumn("OrganisationId", "Core_Organisations");
            Alter.Table("CM_ContentPermissions").AddForeignKeyColumn("PersonId", "Core_Persons");
            Alter.Table("CM_ContentPermissions").AddForeignKeyColumn("ContentId", "CM_ContentItemBases");
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
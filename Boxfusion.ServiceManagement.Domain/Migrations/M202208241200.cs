using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;
using Shesha.FluentMigrator;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.Migration", Version = "1.0")]

namespace Boxfusion.ServiceManagement
{
    [Migration(202208241200)]
    public class M202208241200 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {

            Create.Table("SM_CaseRoutings")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("AssignStepRequired").AsBoolean()
             .WithColumn("CanCaptureExternalRefNo").AsBoolean()
             .WithColumn("CanCloseToResolve").AsBoolean()
             .WithColumn("CaseCategoryLkp").AsInt64().Nullable()
             .WithColumn("ResolutionMethodLkp").AsInt64().Nullable();


            Create.Table("SM_CaseTypes")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("HintText").AsString()
             .WithColumn("IsPublicField").AsBoolean()
             .WithColumn("Name").AsString()
             .WithColumn("IsContactDetailsRequired").AsBoolean()
             .WithColumn("ExtSysId").AsString()
             .WithColumn("ExtSysSource").AsString()
             .WithColumn("MarketUrl").AsString()
             .WithColumn("IsPublicFieldDefault").AsString()
             .WithColumn("LastUpdatedTimestamp").AsDateTime()
             .WithColumn("BackendCreateForm").AsString()
             .WithColumn("BackendDetailsForm").AsString()
             .WithColumn("MobileCreateForm").AsString()
             .WithColumn("MobileDetailsForm").AsString()
             .WithColumn("FlagsLkp").AsInt64().Nullable()
             .WithColumn("DefaultPriorityLkp").AsInt64().Nullable()
             .WithColumn("CategoryLkp").AsInt64().Nullable()
             .WithColumn("SubCategoryLkp").AsInt64().Nullable();


            Create.Table("SM_EscalationRules")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("AssignmentModelLkp").AsInt64().Nullable()
             .WithColumn("EscalationTimeLkp").AsInt64().Nullable()
             .WithColumn("EscalationTypeLkp").AsInt64().Nullable()
             .WithColumn("Level").AsInt32()
             .WithColumn("OrderIndex").AsInt32();


            Create.Table("SM_SLAPolicies")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Description").AsString()
             .WithColumn("Name").AsString();


            Create.Table("SM_SLATargets")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("EscalationEnabled").AsBoolean()
             .WithColumn("OperationalHoursLkp").AsInt64().Nullable()
             .WithColumn("PriorityLkp").AsInt64().Nullable()
             .WithColumn("ResolutionTimeTicks").AsInt64()
             .WithColumn("ResponseTimeTicks").AsInt64();

            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "ResolutionMethods")
               ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CancellationReasons")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseStatuses")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseSubStatuses")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseVisibilities")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "NotificationMethods")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "Priorities")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "ReportedByChannels")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseFlags")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseSubCategories")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "Priorities")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "CaseCategories")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "AssignmentModels")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "EscalationTimes")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "EscalationTypes")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "SLATargetOperationalHours")
                ;


            this.Shesha().ReferenceListCreate("Boxfusion.ServiceManagement", "SLATargetPriorities")
                ;


            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("CaseTypeId", "SM_CaseTypes");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("AreaLevel1Id", "Core_Areas");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("AreaLevel2Id", "Core_Areas");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("AreaLevel3Id", "Core_Areas");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("AreaLevel4Id", "Core_Areas");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("DefaultOrganisationAssignedId", "Core_Organisations");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("FacilityId", "Core_Facilities");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("SlaPolicyId", "SM_SLAPolicies");
            Alter.Table("SM_CaseRoutings").AddForeignKeyColumn("DefaulPersonAssignedId", "Core_Persons");
            Alter.Table("SM_CaseTypes").AddForeignKeyColumn("ResponsibleOrganisationId", "Core_Organisations");
            Alter.Table("SM_CaseTypes").AddForeignKeyColumn("LastUpdatedUserId", "Core_Persons");
            Alter.Table("SM_EscalationRules").AddForeignKeyColumn("SlaPolicyId", "SM_SLAPolicies");
            Alter.Table("SM_EscalationRules").AddForeignKeyColumn("NotificationId", "Core_Notifications");
            Alter.Table("SM_SLATargets").AddForeignKeyColumn("SlaPolicyId", "SM_SLAPolicies");
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
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.ServiceManagement.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.ServiceManagement.CaseType")]
    [Table("SM_CaseTypes")]
    [Discriminator]
    public class CaseType : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string HintText { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool IsPublicField { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool IsContactDetailsRequired { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string ExtSysId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string ExtSysSource { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string MarketUrl { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string IsPublicFieldDefault { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime LastUpdatedTimestamp { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string BackendCreateForm { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string BackendDetailsForm { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string MobileCreateForm { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string MobileDetailsForm { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "CaseFlag")]
        public virtual long? Flags { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "Priority")]
        public virtual long? DefaultPriority { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "CaseCategory")]
        public virtual long? Category { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "CaseSubCategory")]
        public virtual long? SubCategory { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation ResponsibleOrganisation { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person LastUpdatedUser { get; set; }
    }
}
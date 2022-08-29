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
    [Entity(TypeShortAlias = "Boxfusion.ServiceManagement.CaseRouting")]
    [Table("SM_CaseRoutings")]
    [Discriminator]
    public class CaseRouting : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool AssignStepRequired { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool CanCaptureExternalRefNo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool CanCloseToResolve { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "CaseCategory")]
        public virtual long? CaseCategory { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "ResolutionMethod")]
        public virtual long? ResolutionMethod { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual CaseType CaseType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Area AreaLevel1 { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Area AreaLevel2 { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Area AreaLevel3 { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Area AreaLevel4 { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation DefaultOrganisationAssigned { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Facility Facility { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual SLAPolicy SlaPolicy { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person DefaulPersonAssigned { get; set; }
    }
}
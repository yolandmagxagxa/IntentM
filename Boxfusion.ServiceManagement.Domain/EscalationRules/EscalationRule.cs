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
    [Entity(TypeShortAlias = "Boxfusion.ServiceManagement.EscalationRule")]
    [Table("SM_EscalationRules")]
    [Discriminator]
    public class EscalationRule : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "AssignmentModel")]
        public virtual long? AssignmentModel { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "EscalationTime")]
        public virtual long? EscalationTime { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "EscalationType")]
        public virtual long? EscalationType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int Level { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual SLAPolicy SlaPolicy { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Notification Notification { get; set; }
    }
}
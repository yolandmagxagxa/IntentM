using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.ServiceManagement.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.ServiceManagement.SLATarget")]
    [Table("SM_SLATargets")]
    [Discriminator]
    public class SLATarget : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual bool EscalationEnabled { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "SLATargetOperationalHours")]
        public virtual long? OperationalHours { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ServiceManagement", "SLATargetPriority")]
        public virtual long? Priority { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual long ResolutionTimeTicks { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual long ResponseTimeTicks { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual SLAPolicy SlaPolicy { get; set; }
    }
}
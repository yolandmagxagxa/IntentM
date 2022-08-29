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
    [Entity(TypeShortAlias = "Boxfusion.ServiceManagement.SLAPolicy")]
    [Table("SM_SLAPolicies")]
    [Discriminator]
    public class SLAPolicy : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Name { get; set; }
    }
}
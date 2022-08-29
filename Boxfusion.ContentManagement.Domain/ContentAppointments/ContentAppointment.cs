using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.ContentManagement.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.ContentManagement.ContentAppointment")]
    [Table("CM_ContentAppointments")]
    [Discriminator]
    public class ContentAppointment : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "Role")]
        public virtual long? Role { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual ContentItemBase Owner { get; set; }
    }
}
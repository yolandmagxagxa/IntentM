using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.Dep.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.Dep.EventPresenter")]
    [Table("DEP_EventPresenters")]
    [Discriminator]
    public class EventPresenter : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime Time { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Event Event { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
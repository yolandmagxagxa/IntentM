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
    [Entity(TypeShortAlias = "Boxfusion.Dep.Contact")]
    [Table("DEP_Contacts")]
    [Discriminator]
    public class Contact : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string TwitterHandle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string FacebookHandle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string InstaHandle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string LinkedInHandle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string JobTitle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.Dep", "ContactFlags")]
        public virtual long? Flags { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
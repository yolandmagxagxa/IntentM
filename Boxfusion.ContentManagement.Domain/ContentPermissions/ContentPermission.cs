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
    [Entity(TypeShortAlias = "Boxfusion.ContentManagement.ContentPermission")]
    [Table("CM_ContentPermissions")]
    [Discriminator]
    public class ContentPermission : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "PermissionType")]
        public virtual long? Type { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Permission { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation Organisation { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual ContentItemBase Content { get; set; }
    }
}
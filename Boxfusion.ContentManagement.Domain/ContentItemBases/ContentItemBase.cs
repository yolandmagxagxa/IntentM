using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.ContentManagement.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.ContentManagement.ContentItemBase")]
    [Table("CM_ContentItemBases")]
    [Discriminator]
    public class ContentItemBase : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string ImageIconUrl { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool AllowLiking { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool AllowCommenting { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime ValidFrom { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime ValidTo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool CanExport { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime PublishedDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Icon { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "AllowableContentType")]
        public virtual long? AllowableContentType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "OrderMethod")]
        public virtual long? OrderingMethod { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "Flag")]
        public virtual long? Flags { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.ContentManagement", "PublicationStatus")]
        public virtual long? PublicationStatus { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Attribute { get; set; }
    }
}
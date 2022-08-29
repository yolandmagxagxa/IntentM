using System;
using System.ComponentModel.DataAnnotations;
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
    [Entity(TypeShortAlias = "Boxfusion.ContentManagement.ContentItem")]

    public class ContentItem : ContentItemBase
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string ContentUrl { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string WebPage { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile PreviewImage { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile Content { get; set; }
    }
}
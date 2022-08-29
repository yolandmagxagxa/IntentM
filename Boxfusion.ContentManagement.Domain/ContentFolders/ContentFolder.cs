using System;
using System.ComponentModel.DataAnnotations;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Boxfusion.ContentManagement.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Boxfusion.ContentManagement.ContentFolder")]

    public class ContentFolder : ContentItemBase
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime DatePublished { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool AllowSubFolders { get; set; }
    }
}
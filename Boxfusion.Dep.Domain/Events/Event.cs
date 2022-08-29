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
    [Entity(TypeShortAlias = "Boxfusion.Dep.Event")]
    [Table("DEP_Events")]
    [Discriminator]
    public class Event : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime StartDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime EndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string EventLink { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Venue { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Agenda { get; set; }

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
        public virtual decimal Lat { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal Long { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Boxfusion.Dep", "EventCategory")]
        public virtual long? Category { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile EventImage { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile AgendaFile { get; set; }
    }
}
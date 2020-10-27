using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Web.Api.Models
{
    public class Subscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("SourceRefId")]
        public long SourceId { get; set; }

        public virtual Source Source { get; set; }

        public DateTime? LastLoadedTime { get; set; }
    }
}

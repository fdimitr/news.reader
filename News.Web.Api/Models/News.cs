using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Web.Api.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("SourceRefId")]
        public long NewsSourceId { get; set; }

        [StringLength(128)]
        public string Subject { get; set; }

        [StringLength(256)]
        public string Url { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [StringLength(64)]
        public string Category { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}

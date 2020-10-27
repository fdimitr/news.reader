using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Web.Api.Models
{
    public class Source
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("GroupRefId")]
        public long GroupId { get; set; }

        public virtual ICollection<News> News { get; set; }

        [Required]
        [StringLength(256)]
        public string Url { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public int Sort { get; set; }

        public int UpdateFrequency { get; set; }

        public DateTime? LastLoadedTime { get; set; }
    }
}

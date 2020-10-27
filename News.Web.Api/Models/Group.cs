using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Web.Api.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Source> Sources { get; set; }

        [DefaultValue(true)]
        public bool isActive { get; set; }
    }
}

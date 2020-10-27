using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Web.Api.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(16)]
        public string Login { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}

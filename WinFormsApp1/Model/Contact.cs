using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact_management.Model
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        public string Town { get; set; }

        [Required]
        [StringLength(25)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Country { get; set; }

        public DateTime? Birthday { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}

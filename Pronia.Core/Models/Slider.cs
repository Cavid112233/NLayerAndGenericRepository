using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Models
{
    public class Slider : BaseEntity
    {
        [Required]
        public string Sale { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; } = null!;
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string? ButtonName { get; set; }
    }
}

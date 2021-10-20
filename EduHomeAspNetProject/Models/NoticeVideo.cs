using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class NoticeVideo
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Link { get; set; }
    }
}

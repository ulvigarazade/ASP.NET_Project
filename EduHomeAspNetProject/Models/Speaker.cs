using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(100)]
        public string Profession { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}

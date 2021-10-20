using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        public int TeacherAboutId { get; set; }
        public TeacherAbout TeacherAbout { get; set; }
        public int TeacherSkillId { get; set; }
        public TeacherSkill TeacherSkill { get; set; }
        public List<TeacherHobby> TeacherHobbies { get; set; }
        public int TeacherStateId { get; set; }
        public TeacherState TeacherState { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}

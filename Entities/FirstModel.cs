using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Entities
{
    public class FirstModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Place { get; set; } = string.Empty;
    }
}
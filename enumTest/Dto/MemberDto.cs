using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace enumTest.Dto
{
    public class MemberDto
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        public string Mobile { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [Required]
        public string Gender { get; set; }
    }
}

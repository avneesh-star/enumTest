using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace enumTest.Dto
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EGender
    {
        [Description("Male")]
        Male = 1,

        [Description("Female")]
        Female = 2,

        [Description("Diverse")]
        Diverse = 3,
    }
}

using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FunctionAppJsonParseTest
{
    public class MyDataClass
    {
        public MyEnum MyEnum { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MyEnum
    {
        [EnumMember(Value = "value1")]
        key1,
        [EnumMember(Value = "value2")]
        key2
    }
}

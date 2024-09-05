using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Octokit.Model
{
    /// <summary>
    /// Properties by which environments connections can be ordered
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvironmentOrderField
    {
        /// <summary>
        /// Order environments by name.
        /// </summary>
        [EnumMember(Value = "NAME")]
        Name,
    }
}
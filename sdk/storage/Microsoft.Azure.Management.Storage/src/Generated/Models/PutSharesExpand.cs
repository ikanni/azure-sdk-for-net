// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PutSharesExpand.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PutSharesExpand
    {
        [EnumMember(Value = "snapshots")]
        Snapshots
    }
    internal static class PutSharesExpandEnumExtension
    {
        internal static string ToSerializedValue(this PutSharesExpand? value)
        {
            return value == null ? null : ((PutSharesExpand)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PutSharesExpand value)
        {
            switch( value )
            {
                case PutSharesExpand.Snapshots:
                    return "snapshots";
            }
            return null;
        }

        internal static PutSharesExpand? ParsePutSharesExpand(this string value)
        {
            switch( value )
            {
                case "snapshots":
                    return PutSharesExpand.Snapshots;
            }
            return null;
        }
    }
}

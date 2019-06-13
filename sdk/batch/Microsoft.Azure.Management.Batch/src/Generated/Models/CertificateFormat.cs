// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateFormat
    {
        /// <summary>
        /// The certificate is a PFX (PKCS#12) formatted certificate or
        /// certificate chain.
        /// </summary>
        [EnumMember(Value = "Pfx")]
        Pfx,
        /// <summary>
        /// The certificate is a base64-encoded X.509 certificate.
        /// </summary>
        [EnumMember(Value = "Cer")]
        Cer
    }
    internal static class CertificateFormatEnumExtension
    {
        internal static string ToSerializedValue(this CertificateFormat? value)
        {
            return value == null ? null : ((CertificateFormat)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CertificateFormat value)
        {
            switch( value )
            {
                case CertificateFormat.Pfx:
                    return "Pfx";
                case CertificateFormat.Cer:
                    return "Cer";
            }
            return null;
        }

        internal static CertificateFormat? ParseCertificateFormat(this string value)
        {
            switch( value )
            {
                case "Pfx":
                    return CertificateFormat.Pfx;
                case "Cer":
                    return CertificateFormat.Cer;
            }
            return null;
        }
    }
}
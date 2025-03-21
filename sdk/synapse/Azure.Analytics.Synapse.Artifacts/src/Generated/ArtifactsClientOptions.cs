// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Client options for ArtifactsClient. </summary>
    public partial class ArtifactsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2019_06_01_preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2019-06-01-preview". </summary>
            V2019_06_01_preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ArtifactsClientOptions. </summary>
        public ArtifactsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2019_06_01_preview => "2019-06-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}

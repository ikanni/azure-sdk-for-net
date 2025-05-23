// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Error details. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Server defined error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal Error(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Server defined error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="target"> The target of the error. </param>
        /// <param name="details"> An array of errors that led to the reported error. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        /// <param name="occurredDateTime"> Date and time in UTC when the error occurred. </param>
        internal Error(string code, string message, string target, IReadOnlyList<Error> details, InnerError innererror, DateTimeOffset? occurredDateTime)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
            OccurredDateTime = occurredDateTime;
        }

        /// <summary> Server defined error code. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> The target of the error. </summary>
        public string Target { get; }
        /// <summary> An array of errors that led to the reported error. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerError Innererror { get; }
        /// <summary> Date and time in UTC when the error occurred. </summary>
        public DateTimeOffset? OccurredDateTime { get; }
    }
}

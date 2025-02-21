// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.DocumentTranslation
{
    /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
    public partial class DocumentTranslationError
    {
        /// <summary> Initializes a new instance of DocumentTranslationError. </summary>
        /// <param name="message"> Gets high level error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal DocumentTranslationError(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Message = message;
        }

        /// <summary> Initializes a new instance of DocumentTranslationError. </summary>
        /// <param name="errorCode"> Enums containing high level error codes. </param>
        /// <param name="message"> Gets high level error message. </param>
        /// <param name="target">
        /// Gets the source of the error.
        /// 
        /// For example it would be &quot;documents&quot; or &quot;document id&quot; in case of invalid document.
        /// </param>
        /// <param name="innerError">
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// 
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </param>
        internal DocumentTranslationError(DocumentTranslationErrorCode? errorCode, string message, string target, DocumentTranslationInnerError innerError)
        {
            ErrorCode = errorCode;
            Message = message;
            Target = target;
            InnerError = innerError;
        }
        /// <summary> Gets high level error message. </summary>
        public string Message { get; }
        /// <summary>
        /// Gets the source of the error.
        /// 
        /// For example it would be &quot;documents&quot; or &quot;document id&quot; in case of invalid document.
        /// </summary>
        public string Target { get; }
        /// <summary>
        /// New Inner Error format which conforms to Cognitive Services API Guidelines which is available at https://microsoft.sharepoint.com/%3Aw%3A/t/CognitiveServicesPMO/EUoytcrjuJdKpeOKIK_QRC8BPtUYQpKBi8JsWyeDMRsWlQ?e=CPq8ow.
        /// 
        /// This contains required properties ErrorCode, message and optional properties target, details(key value pair), inner error(this can be nested).
        /// </summary>
        public DocumentTranslationInnerError InnerError { get; }
    }
}

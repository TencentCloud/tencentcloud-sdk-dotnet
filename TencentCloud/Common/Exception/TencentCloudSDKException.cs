/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;

namespace TencentCloud.Common
{
    /// <summary>
    ///   Exception class for Tencent Cloud SDK errors.
    ///   This exception is thrown when an error occurs during an API request.
    ///   It provides information about the error, including the message, request ID, and error code.
    /// </summary>
    public class TencentCloudSDKException : Exception
    {
        /// <summary>
        ///   Constructor for TencentCloudSDKException.
        /// </summary>
        /// <param name="message"> The error message. </param>
        public TencentCloudSDKException(string message)
            : this(message, "")
        {
        }

        /// <summary>
        ///   Constructor for TencentCloudSDKException with request ID.
        /// </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="requestId"> The request ID associated with the error. </param>
        public TencentCloudSDKException(string message, string requestId) :
            base(message)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        ///   Constructor for TencentCloudSDKException with an inner exception.
        /// </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="innerException"> The inner exception that caused this exception. </param>
        public TencentCloudSDKException(string message, Exception innerException) :
            base(message, innerException)
        {
        }

        /// <summary>
        ///   Constructor for TencentCloudSDKException with error code and request ID.
        /// </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="errorCode"> The error code returned by the API. </param>
        /// <param name="requestId"> The request ID associated with the error. </param>
        public TencentCloudSDKException(string message, string errorCode, string requestId) :
            base(message)
        {
            RequestId = requestId;
            ErrorCode = errorCode;
        }

        /// <summary>
        ///   The request ID associated with the error.
        ///   This can be helpful for debugging and tracking down issues with Tencent Cloud.
        /// </summary>
        public string RequestId { get; private set; }

        /// <summary>
        ///   The error code returned by the Tencent Cloud API.
        ///   This provides more specific information about the type of error that occurred.
        /// </summary>
        public string ErrorCode { get; private set; }

        /// <summary>
        ///   Overrides the ToString() method to provide a more informative string representation
        ///   of the exception, including the request ID (if available).
        /// </summary>
        /// <returns> A string representation of the exception. </returns>
        public override string ToString()
        {
            string msg = "";
            if (!string.IsNullOrEmpty(RequestId))
                msg += $"requestId: {RequestId} ";
            return msg + base.ToString();
        }
    }
}
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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;

namespace TencentCloud.Common
{
    /// <summary>
    ///   Abstract base class for models representing Server-Sent Events (SSE).
    ///   Provides functionality to parse and iterate over SSE events from an HTTP response.
    ///   Classes representing specific SSE responses should inherit from this class.
    /// </summary>
    [JsonObject] // Indicates that this class can be serialized/deserialized by Newtonsoft.Json
    public abstract class AbstractSSEModel : AbstractModel, IEnumerable<AbstractSSEModel.SSE>, IDisposable
    {
        /// <summary>
        ///   Inner class representing a single Server-Sent Event.
        /// </summary>
        public class SSE
        {
            /// <summary>
            ///   The event ID (optional).
            /// </summary>
            public string Id;

            /// <summary>
            ///   The event type (optional).
            /// </summary>
            public string Event;

            /// <summary>
            ///   The event data.
            /// </summary>
            public string Data;

            /// <summary>
            ///   The retry delay in milliseconds (optional).
            /// </summary>
            public int Retry;
        }

        /// <summary>
        ///   The request ID associated with the SSE stream.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        ///   The HttpResponseMessage representing the ongoing SSE stream.
        ///   This is used internally to read and process events.
        /// </summary>
        internal HttpResponseMessage Response;

        /// <summary>
        ///   Flag indicating whether the object has been disposed.
        /// </summary>
        private bool _disposed;

        /// <summary>
        ///   Enumerator class for iterating over SSE events in the response stream.
        /// </summary>
        private class Enumerator : IEnumerator<SSE>
        {
            /// <summary>
            ///   The StreamReader to read the SSE stream.
            /// </summary>
            private readonly StreamReader _reader;

            /// <summary>
            ///   Constructor for the Enumerator.
            /// </summary>
            /// <param name="response">The AbstractSSEModel containing the HttpResponseMessage.</param>
            internal Enumerator(AbstractSSEModel response)
            {
                // Get the response stream and create a StreamReader
                var stream = response.Response.Content.ReadAsStreamAsync()
                    .ConfigureAwait(false).GetAwaiter().GetResult();
                _reader = new StreamReader(stream);
            }

            /// <summary>
            ///   Disposes of the StreamReader.
            /// </summary>
            public void Dispose()
            {
                _reader.Dispose();
            }

            /// <summary>
            ///   Moves to the next SSE event in the stream.
            /// </summary>
            /// <returns>True if there is another event, false if the end of the stream is reached.</returns>
            public bool MoveNext()
            {
                // If the end of the stream is reached, return false
                if (_reader.EndOfStream)
                    return false;

                var e = new SSE();
                var sb = new StringBuilder();
                // Read lines from the stream until an empty line is encountered (event separator)
                while (true)
                {
                    var line = _reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        break;

                    // Skip comments (lines starting with ':')
                    if (line[0] == ':')
                        continue;

                    // Parse the line based on the key (e.g., "id:", "event:", "data:")
                    var colonIdx = line.IndexOf(':');
                    var key = line.Substring(0, colonIdx);
                    switch (key)
                    {
                        case "id":
                            e.Id = line.Substring(colonIdx + 1);
                            break;
                        case "event":
                            e.Event = line.Substring(colonIdx + 1);
                            break;
                        case "data":
                            // The spec allows for multiple data fields per event, concatenate them with "\n".
                            if (sb.Length > 0)
                            {
                                sb.Append('\n');
                            }

                            line = line.Substring(colonIdx + 1);
                            // Remove leading space after the colon
                            if (line[0] == ' ')
                            {
                                line = line.Substring(1);
                            }

                            sb.Append(line);
                            break;
                        case "retry":
                            int.TryParse(line.Substring(colonIdx + 1), out e.Retry);
                            break;
                    }
                }

                e.Data = sb.ToString();
                Current = e;
                return true;
            }

            /// <summary>
            ///   Resets the enumerator (not supported).
            /// </summary>
            public void Reset()
            {
                // reset is not supported for SSE streams
                throw new System.NotImplementedException();
            }

            /// <summary>
            ///   Gets the current SSE event.
            /// </summary>
            public SSE Current { get; private set; }

            /// <summary>
            ///   Gets the current SSE event (object version).
            /// </summary>
            object IEnumerator.Current => Current;
        }

        /// <summary>
        ///   Returns an enumerator that iterates through the SSE events in the response stream.
        /// </summary>
        /// <returns>An IEnumerator&lt;SSE&gt; for the SSE stream.</returns>
        public IEnumerator<SSE> GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <summary>
        ///   Returns an enumerator that iterates through the SSE events in the response stream (non-generic version).
        /// </summary>
        /// <returns>An IEnumerator for the SSE stream.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// SSE models don't typically need ToMap functionality
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
        }

        /// <summary>
        ///   Indicates whether the model represents a stream (i.e., an SSE response).
        ///   Returns true if the Response property is not null, meaning it's an active SSE stream.
        /// </summary>
        public override bool IsStream => Response != null;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                Response?.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
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

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TencentCloud.Common
{
    /// <summary>
    ///   A generic request class that allows for arbitrary JSON payloads.
    ///   This class can be used to make API requests with dynamic or complex request structures.
    ///   It implements the ISerializable interface for custom serialization.
    /// </summary>
    public sealed class CommonRequest : AbstractModel, ISerializable
    {
        /// <summary>
        ///   The JSON request body, represented as a JObject.
        /// </summary>
        private readonly JObject _body;

        /// <summary>
        ///   Constructor for CommonRequest, initializing it with a JSON string.
        /// </summary>
        /// <param name="jsonStr"> The JSON string representing the request body. </param>
        public CommonRequest(string jsonStr)
        {
            _body = JObject.Parse(jsonStr);
        }

        /// <summary>
        ///   Constructor for CommonRequest, initializing it with a serializable object.
        /// </summary>
        /// <param name="serializable"> An object that can be serialized to JSON. </param>
        public CommonRequest(object serializable)
        {
            _body = JObject.Parse(JsonConvert.SerializeObject(serializable));
        }

        /// <summary>
        ///   Populates a dictionary with the request parameters.
        ///   This method is required by the AbstractModel base class.
        /// </summary>
        /// <param name="map"> The dictionary to populate. </param>
        /// <param name="prefix"> The prefix to use for parameter names. </param>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            ToMapFromValue(map, prefix, _body);
        }

        /// <summary>
        ///   Recursively processes a JToken to extract key-value pairs for the parameter dictionary.
        ///   Handles nested objects and arrays within the JSON structure.
        /// </summary>
        /// <param name="map"> The dictionary to populate. </param>
        /// <param name="prefix"> The prefix for parameter names (used for nested structures). </param>
        /// <param name="token"> The JToken to process. </param>
        private void ToMapFromValue(Dictionary<string, string> map, string prefix, JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Object:
                    // Process each property in the JSON object
                    foreach (var kv in token.Value<JObject>())
                    {
                        if (kv.Value == null)
                            continue;
                        ToMapFromValue(map, prefix == "" ? kv.Key : prefix + "." + kv.Key, kv.Value);
                    }

                    break;
                case JTokenType.Array:
                    // Process each element in the JSON array
                    var i = -1;
                    foreach (var v in token.Value<JArray>())
                    {
                        i++;
                        if (v == null)
                            continue;
                        ToMapFromValue(map, $"{prefix}.{i}", v);
                    }

                    break;
                case JTokenType.Integer:
                case JTokenType.Float:
                case JTokenType.String:
                case JTokenType.Boolean:
                    // Handle simple data types by setting the parameter value
                    SetParamSimple(map, prefix, token);
                    break;
                case JTokenType.Null:
                    // Skip null values
                    break;
                // Handle other JTokenType values (and throw an exception for unsupported types)
                case JTokenType.None:
                case JTokenType.Constructor:
                case JTokenType.Property:
                case JTokenType.Comment:
                case JTokenType.Undefined:
                case JTokenType.Date:
                case JTokenType.Raw:
                case JTokenType.Bytes:
                case JTokenType.Guid:
                case JTokenType.Uri:
                case JTokenType.TimeSpan:
                default:
                    throw new TencentCloudSDKException($"invalid json value {token.Type}");
            }
        }

        /// <summary>
        ///   Serializes the request body (JObject) to a JSON string.
        ///   This method is part of the ISerializable interface implementation.
        /// </summary>
        /// <returns> The JSON string representing the request body. </returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(_body);
        }
    }
}
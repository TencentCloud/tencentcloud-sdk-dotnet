/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMessageDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 消息体
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// 用户自定义属性
        /// </summary>
        [JsonProperty("UserProperties")]
        public UserProperty[] UserProperties{ get; set; }

        /// <summary>
        /// 消息存储时间，毫秒级时间戳。
        /// </summary>
        [JsonProperty("StoreTimestamp")]
        public long? StoreTimestamp{ get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// 生产者地址
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// 源topic
        /// </summary>
        [JsonProperty("OriginTopic")]
        public string OriginTopic{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArrayObj(map, prefix + "UserProperties.", this.UserProperties);
            this.SetParamSimple(map, prefix + "StoreTimestamp", this.StoreTimestamp);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "OriginTopic", this.OriginTopic);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


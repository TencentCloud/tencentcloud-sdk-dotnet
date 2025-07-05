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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AcknowledgeMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// 用作标识消息的唯一的ID（可从 receiveMessage 的返回值中获得）
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// Topic 名字（可从 receiveMessage 的返回值中获得）这里尽量需要使用topic的全路径，即：tenant/namespace/topic。如果不指定，默认使用的是：public/default
        /// </summary>
        [JsonProperty("AckTopic")]
        public string AckTopic{ get; set; }

        /// <summary>
        /// 订阅者的名字，可以从receiveMessage的返回值中获取到。这里尽量与receiveMessage中的订阅者保持一致，否则没办法正确ack 接收回来的消息。
        /// </summary>
        [JsonProperty("SubName")]
        public string SubName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "AckTopic", this.AckTopic);
            this.SetParamSimple(map, prefix + "SubName", this.SubName);
        }
    }
}


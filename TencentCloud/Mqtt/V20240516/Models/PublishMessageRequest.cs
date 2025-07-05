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

    public class PublishMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 消息负载 Payload，是消息的实际内容，需要按 encoding 指定的编码方式进行编码
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 消息目的主题，该参数与 TargetClientId 二选一
        /// </summary>
        [JsonProperty("TargetTopic")]
        public string TargetTopic{ get; set; }

        /// <summary>
        /// 消息目的客户端 ID，该参数与 TargetTopic 二选一
        /// </summary>
        [JsonProperty("TargetClientId")]
        public string TargetClientId{ get; set; }

        /// <summary>
        /// 消息 payload 编码，可选 plain 或 base64，默认为 plain（即不编码）
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// 消息的服务质量等级，默认为 1
        /// QoS 0（至多一次）消息发送后，不保证接收方一定收到，也不要求接收方确认。
        /// QoS 1（至少一次）消息至少被接收方成功接收一次，但可能重复。
        /// QoS 2（恰好一次）消息确保被接收方接收且仅接收一次，无重复。
        /// </summary>
        [JsonProperty("Qos")]
        public long? Qos{ get; set; }

        /// <summary>
        /// 是否为保留消息，默认为 false，且仅支持发布到主题的消息设置为 true
        /// </summary>
        [JsonProperty("Retain")]
        public bool? Retain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "TargetTopic", this.TargetTopic);
            this.SetParamSimple(map, prefix + "TargetClientId", this.TargetClientId);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Retain", this.Retain);
        }
    }
}


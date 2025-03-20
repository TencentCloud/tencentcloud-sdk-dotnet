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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTMessageItem : AbstractModel
    {
        
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消息tag
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 消息key
        /// </summary>
        [JsonProperty("Keys")]
        public string Keys{ get; set; }

        /// <summary>
        /// 客户端地址	
        /// </summary>
        [JsonProperty("ProducerAddr")]
        public string ProducerAddr{ get; set; }

        /// <summary>
        /// 消息发送时间	
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// 死信重发次数	
        /// </summary>
        [JsonProperty("DeadLetterResendTimes")]
        public long? DeadLetterResendTimes{ get; set; }

        /// <summary>
        /// 死信重发成功次数
        /// </summary>
        [JsonProperty("DeadLetterResendSuccessTimes")]
        public long? DeadLetterResendSuccessTimes{ get; set; }

        /// <summary>
        /// 子topic
        /// </summary>
        [JsonProperty("SubTopic")]
        public string SubTopic{ get; set; }

        /// <summary>
        /// 消息质量等级
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "DeadLetterResendTimes", this.DeadLetterResendTimes);
            this.SetParamSimple(map, prefix + "DeadLetterResendSuccessTimes", this.DeadLetterResendSuccessTimes);
            this.SetParamSimple(map, prefix + "SubTopic", this.SubTopic);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
        }
    }
}


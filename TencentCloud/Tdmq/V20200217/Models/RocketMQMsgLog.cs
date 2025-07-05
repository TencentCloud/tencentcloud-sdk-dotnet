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

    public class RocketMQMsgLog : AbstractModel
    {
        
        /// <summary>
        /// 消息id
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消息tag
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgTag")]
        public string MsgTag{ get; set; }

        /// <summary>
        /// 消息key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgKey")]
        public string MsgKey{ get; set; }

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
        /// pulsar消息id
        /// </summary>
        [JsonProperty("PulsarMsgId")]
        public string PulsarMsgId{ get; set; }

        /// <summary>
        /// 死信重发次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterResendTimes")]
        public long? DeadLetterResendTimes{ get; set; }

        /// <summary>
        /// 死信重发成功次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResendSuccessCount")]
        public long? ResendSuccessCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "MsgTag", this.MsgTag);
            this.SetParamSimple(map, prefix + "MsgKey", this.MsgKey);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "PulsarMsgId", this.PulsarMsgId);
            this.SetParamSimple(map, prefix + "DeadLetterResendTimes", this.DeadLetterResendTimes);
            this.SetParamSimple(map, prefix + "ResendSuccessCount", this.ResendSuccessCount);
        }
    }
}


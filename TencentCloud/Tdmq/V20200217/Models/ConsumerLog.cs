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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerLog : AbstractModel
    {
        
        /// <summary>
        /// 消息ID。
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消费组。
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// 消费者名称。
        /// </summary>
        [JsonProperty("ConsumerName")]
        public string ConsumerName{ get; set; }

        /// <summary>
        /// 消费时间。
        /// </summary>
        [JsonProperty("ConsumeTime")]
        public string ConsumeTime{ get; set; }

        /// <summary>
        /// 消费者客户端地址。
        /// </summary>
        [JsonProperty("ConsumerAddr")]
        public string ConsumerAddr{ get; set; }

        /// <summary>
        /// 消费耗时（毫秒）。
        /// </summary>
        [JsonProperty("ConsumeUseTime")]
        public ulong? ConsumeUseTime{ get; set; }

        /// <summary>
        /// 消费状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "ConsumerName", this.ConsumerName);
            this.SetParamSimple(map, prefix + "ConsumeTime", this.ConsumeTime);
            this.SetParamSimple(map, prefix + "ConsumerAddr", this.ConsumerAddr);
            this.SetParamSimple(map, prefix + "ConsumeUseTime", this.ConsumeUseTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


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

namespace TencentCloud.Cmq.V20190304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeadLetterPolicy : AbstractModel
    {
        
        /// <summary>
        /// 死信队列。
        /// </summary>
        [JsonProperty("DeadLetterQueue")]
        public string DeadLetterQueue{ get; set; }

        /// <summary>
        /// 死信队列名字。
        /// </summary>
        [JsonProperty("DeadLetterQueueName")]
        public string DeadLetterQueueName{ get; set; }

        /// <summary>
        /// 最大未消费过期时间。Policy为1时必选。范围300-43200，单位秒，需要小于消息最大保留时间MsgRetentionSeconds。
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive{ get; set; }

        /// <summary>
        /// 死信队列策略。
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy{ get; set; }

        /// <summary>
        /// 最大接收次数。
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeadLetterQueue", this.DeadLetterQueue);
            this.SetParamSimple(map, prefix + "DeadLetterQueueName", this.DeadLetterQueueName);
            this.SetParamSimple(map, prefix + "MaxTimeToLive", this.MaxTimeToLive);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "MaxReceiveCount", this.MaxReceiveCount);
        }
    }
}


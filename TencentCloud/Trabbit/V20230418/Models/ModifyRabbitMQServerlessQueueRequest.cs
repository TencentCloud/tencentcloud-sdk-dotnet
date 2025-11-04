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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRabbitMQServerlessQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Vhost参数
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 新修改的备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// MessageTTL参数单位ms,classic类型专用	
        /// </summary>
        [JsonProperty("MessageTTL")]
        public long? MessageTTL{ get; set; }

        /// <summary>
        /// DeadLetterExchange参数。可将过期或被拒绝的消息投往指定的死信 exchange。
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// DeadLetterRoutingKey参数。只能包含字母、数字、"."、"-"，"@"，"_"
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MessageTTL", this.MessageTTL);
            this.SetParamSimple(map, prefix + "DeadLetterExchange", this.DeadLetterExchange);
            this.SetParamSimple(map, prefix + "DeadLetterRoutingKey", this.DeadLetterRoutingKey);
        }
    }
}


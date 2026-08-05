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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ThrottleRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>限流规则标识</p>
        /// </summary>
        [JsonProperty("ThrottleRuleId")]
        public ulong? ThrottleRuleId{ get; set; }

        /// <summary>
        /// <p>限流类型</p><p>枚举值：</p><ul><li>1： 用户/客户端限流</li><li>2： 消费组限流</li><li>3： topic限流</li></ul>
        /// </summary>
        [JsonProperty("ThrottleType")]
        public long? ThrottleType{ get; set; }

        /// <summary>
        /// <p>客户端id</p>
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>消费限流值,单位MB/s</p>
        /// </summary>
        [JsonProperty("ConsumeThrottle")]
        public ulong? ConsumeThrottle{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>topic名称</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>topicId</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ThrottleRuleId", this.ThrottleRuleId);
            this.SetParamSimple(map, prefix + "ThrottleType", this.ThrottleType);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ConsumeThrottle", this.ConsumeThrottle);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
        }
    }
}


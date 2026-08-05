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

    public class CreateThrottleRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例Id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>限流类型:</p><p>枚举值：</p><ul><li>1： 用户/客户端限流</li><li>2： 消费组维度限流</li><li>3： Topic限流</li></ul>
        /// </summary>
        [JsonProperty("ThrottleType")]
        public long? ThrottleType{ get; set; }

        /// <summary>
        /// <p>消费组名</p>
        /// </summary>
        [JsonProperty("GroupNameList")]
        public string[] GroupNameList{ get; set; }

        /// <summary>
        /// <p>消费限流值,生产消费限流值,必填一个单位MB/s</p>
        /// </summary>
        [JsonProperty("ConsumeThrottle")]
        public ulong? ConsumeThrottle{ get; set; }

        /// <summary>
        /// <p>生产限流值,生产消费限流值,单位MB/s</p>
        /// </summary>
        [JsonProperty("ProduceThrottle")]
        public ulong? ProduceThrottle{ get; set; }

        /// <summary>
        /// <p>用户客户端id</p>
        /// </summary>
        [JsonProperty("ClientIdList")]
        public string[] ClientIdList{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserNameList")]
        public string[] UserNameList{ get; set; }

        /// <summary>
        /// <p>topic名称</p>
        /// </summary>
        [JsonProperty("TopicNameList")]
        public string[] TopicNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ThrottleType", this.ThrottleType);
            this.SetParamArraySimple(map, prefix + "GroupNameList.", this.GroupNameList);
            this.SetParamSimple(map, prefix + "ConsumeThrottle", this.ConsumeThrottle);
            this.SetParamSimple(map, prefix + "ProduceThrottle", this.ProduceThrottle);
            this.SetParamArraySimple(map, prefix + "ClientIdList.", this.ClientIdList);
            this.SetParamArraySimple(map, prefix + "UserNameList.", this.UserNameList);
            this.SetParamArraySimple(map, prefix + "TopicNameList.", this.TopicNameList);
        }
    }
}


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

    public class FilterSubscription : AbstractModel
    {
        
        /// <summary>
        /// 是否仅展示包含真实消费者的订阅。
        /// </summary>
        [JsonProperty("ConsumerHasCount")]
        public bool? ConsumerHasCount{ get; set; }

        /// <summary>
        /// 是否仅展示消息堆积的订阅。
        /// </summary>
        [JsonProperty("ConsumerHasBacklog")]
        public bool? ConsumerHasBacklog{ get; set; }

        /// <summary>
        /// 是否仅展示存在消息超期丢弃的订阅。
        /// </summary>
        [JsonProperty("ConsumerHasExpired")]
        public bool? ConsumerHasExpired{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerHasCount", this.ConsumerHasCount);
            this.SetParamSimple(map, prefix + "ConsumerHasBacklog", this.ConsumerHasBacklog);
            this.SetParamSimple(map, prefix + "ConsumerHasExpired", this.ConsumerHasExpired);
        }
    }
}


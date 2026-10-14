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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CkafkaTargetParams : AbstractModel
    {
        
        /// <summary>
        /// <p>要投递到的ckafka topic</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>重试策略</p>
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public RetryPolicy RetryPolicy{ get; set; }

        /// <summary>
        /// <p>事件投递kafka时的协议格式；目前只支持两种格式：1.CloudEvent(完整的cloudevent消息协议)2.CloudEventDataKey(cloudevent协议中的data字段内容)</p>
        /// </summary>
        [JsonProperty("EventDeliveryFormat")]
        public string EventDeliveryFormat{ get; set; }

        /// <summary>
        /// <p>事件顶层Time参数投递格式</p><p>枚举值：</p><ul><li>RFC3339： 将时间戳转换成 YYYY-MM-DDTHH:mm:ssZ 格式</li></ul>
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamObj(map, prefix + "RetryPolicy.", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "EventDeliveryFormat", this.EventDeliveryFormat);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}


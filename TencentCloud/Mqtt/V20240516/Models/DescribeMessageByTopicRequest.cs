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

    public class DescribeMessageByTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>腾讯云MQTT实例ID，从 <a href="https://cloud.tencent.com/document/api/1778/111029">DescribeInstanceList</a>接口或控制台获得。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>home/room</p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>开始时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>查询消息条数，最大1024，默认100.</p>
        /// </summary>
        [JsonProperty("MaxNumber")]
        public long? MaxNumber{ get; set; }

        /// <summary>
        /// <p>消息 body 过滤表达式（Base64 编码），jq 1.6 语法</p><p>枚举值：</p><ul><li>LmxldmVsID09ICJFUlJPUiI=： .level == &quot;ERROR&quot; Base64编码后的字符串</li></ul>
        /// </summary>
        [JsonProperty("FilterExpression")]
        public string FilterExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "MaxNumber", this.MaxNumber);
            this.SetParamSimple(map, prefix + "FilterExpression", this.FilterExpression);
        }
    }
}


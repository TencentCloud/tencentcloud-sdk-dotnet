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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConsumerGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>在线消费者数量</p>
        /// </summary>
        [JsonProperty("ConsumerNum")]
        public long? ConsumerNum{ get; set; }

        /// <summary>
        /// <p>TPS</p>
        /// </summary>
        [JsonProperty("Tps")]
        public long? Tps{ get; set; }

        /// <summary>
        /// <p>消息堆积数量</p>
        /// </summary>
        [JsonProperty("ConsumerLag")]
        public long? ConsumerLag{ get; set; }

        /// <summary>
        /// <p>消费类型，枚举值如下：</p><ul><li>PULL：PULL 消费类型</li><li>PUSH：PUSH 消费类型</li><li>POP：POP 消费类型</li></ul>
        /// </summary>
        [JsonProperty("ConsumeType")]
        public string ConsumeType{ get; set; }

        /// <summary>
        /// <p>创建时间，<strong>Unix时间戳（毫秒）</strong></p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// <p>顺序投递：true<br>并发投递：false</p>
        /// </summary>
        [JsonProperty("ConsumeMessageOrderly")]
        public bool? ConsumeMessageOrderly{ get; set; }

        /// <summary>
        /// <p>是否开启消费</p>
        /// </summary>
        [JsonProperty("ConsumeEnable")]
        public bool? ConsumeEnable{ get; set; }

        /// <summary>
        /// <p>最大重试次数</p>
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>消费模式：<br>BROADCASTING 广播模式<br>CLUSTERING 集群模式</p>
        /// </summary>
        [JsonProperty("MessageModel")]
        public string MessageModel{ get; set; }

        /// <summary>
        /// <p>重试策略</p>
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public RetryPolicy RetryPolicy{ get; set; }

        /// <summary>
        /// <p>消费模式</p><p>枚举值：</p><ul><li>CLUSTERING： 集群/广播消费</li><li>LITE： LiteTopic消费</li></ul><p>默认值：CLUSTERING</p>
        /// </summary>
        [JsonProperty("ConsumeModel")]
        public string ConsumeModel{ get; set; }

        /// <summary>
        /// <p>订阅的轻量主题（仅适用于轻量消费模式）</p>
        /// </summary>
        [JsonProperty("LiteTopic")]
        public string LiteTopic{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerNum", this.ConsumerNum);
            this.SetParamSimple(map, prefix + "Tps", this.Tps);
            this.SetParamSimple(map, prefix + "ConsumerLag", this.ConsumerLag);
            this.SetParamSimple(map, prefix + "ConsumeType", this.ConsumeType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ConsumeMessageOrderly", this.ConsumeMessageOrderly);
            this.SetParamSimple(map, prefix + "ConsumeEnable", this.ConsumeEnable);
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MessageModel", this.MessageModel);
            this.SetParamObj(map, prefix + "RetryPolicy.", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ConsumeModel", this.ConsumeModel);
            this.SetParamSimple(map, prefix + "LiteTopic", this.LiteTopic);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

